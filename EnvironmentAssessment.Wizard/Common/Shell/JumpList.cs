using Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace Microsoft.Windows.Shell
{
	[ContentProperty("JumpItems")]
	public sealed class JumpList : ISupportInitialize
	{
		private class _RejectedJumpItemPair
		{
			public JumpItem JumpItem
			{
				get;
				set;
			}

			public JumpItemRejectionReason Reason
			{
				get;
				set;
			}
		}

		private class _ShellObjectPair
		{
			public JumpItem JumpItem
			{
				get;
				set;
			}

			public object ShellObject
			{
				get;
				set;
			}

			public static void ReleaseShellObjects(List<JumpList._ShellObjectPair> list)
			{
				if (list != null)
				{
					foreach (JumpList._ShellObjectPair current in list)
					{
						object shellObject = current.ShellObject;
						current.ShellObject = null;
						Utility.SafeRelease<object>(ref shellObject);
					}
				}
			}
		}

		private static readonly object s_lock;

		private static readonly Dictionary<Application, JumpList> s_applicationMap;

		private Application _application;

		private bool? _initializing;

		private List<JumpItem> _jumpItems;

		private static readonly string _FullName;

		public event EventHandler<JumpItemsRejectedEventArgs> JumpItemsRejected;

		public event EventHandler<JumpItemsRemovedEventArgs> JumpItemsRemovedByUser;

		public bool ShowFrequentCategory
		{
			get;
			set;
		}

		public bool ShowRecentCategory
		{
			get;
			set;
		}

		[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
		public List<JumpItem> JumpItems
		{
			get
			{
				return this._jumpItems;
			}
		}

		private bool _IsUnmodified
		{
			get
			{
				return !this._initializing.HasValue && this.JumpItems.Count == 0 && !this.ShowRecentCategory && !this.ShowFrequentCategory;
			}
		}

		private static string _RuntimeId
		{
			get
			{
				string result;
				HRESULT hrLeft = NativeMethods.GetCurrentProcessExplicitAppUserModelID(out result);
				if (hrLeft == HRESULT.E_FAIL)
				{
					hrLeft = HRESULT.S_OK;
					result = null;
				}
				hrLeft.ThrowIfFailed();
				return result;
			}
		}

		[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
		static JumpList()
		{
			JumpList.s_lock = new object();
			JumpList.s_applicationMap = new Dictionary<Application, JumpList>();
			JumpList._FullName = NativeMethods.GetModuleFileName(IntPtr.Zero);
		}

		public static void AddToRecentCategory(string itemPath)
		{
			Verify.FileExists(itemPath, "itemPath");
			itemPath = Path.GetFullPath(itemPath);
			NativeMethods.SHAddToRecentDocs(itemPath);
		}

		[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
		public static void AddToRecentCategory(JumpPath jumpPath)
		{
			Verify.IsNotNull<JumpPath>(jumpPath, "jumpPath");
			JumpList.AddToRecentCategory(jumpPath.Path);
		}

		public static void AddToRecentCategory(JumpTask jumpTask)
		{
			Verify.IsNotNull<JumpTask>(jumpTask, "jumpTask");
			if (Utility.IsOSWindows7OrNewer)
			{
				IShellLinkW shellLinkW = JumpList.CreateLinkFromJumpTask(jumpTask, false);
				try
				{
					if (shellLinkW != null)
					{
						NativeMethods.SHAddToRecentDocs(shellLinkW);
					}
				}
				finally
				{
					Utility.SafeRelease<IShellLinkW>(ref shellLinkW);
				}
			}
		}

		public static void SetJumpList(Application application, JumpList value)
		{
			Verify.IsNotNull<Application>(application, "application");
			lock (JumpList.s_lock)
			{
				JumpList jumpList;
				if (JumpList.s_applicationMap.TryGetValue(application, out jumpList) && jumpList != null)
				{
					jumpList._application = null;
				}
				JumpList.s_applicationMap[application] = value;
				if (value != null)
				{
					value._application = application;
				}
			}
			if (value != null)
			{
				value.ApplyFromApplication();
			}
		}

		public static JumpList GetJumpList(Application application)
		{
			Verify.IsNotNull<Application>(application, "application");
			JumpList result;
			JumpList.s_applicationMap.TryGetValue(application, out result);
			return result;
		}

		public JumpList() : this(null, false, false)
		{
			this._initializing = null;
		}

		public JumpList(IEnumerable<JumpItem> items, bool showFrequent, bool showRecent)
		{
			if (items != null)
			{
				this._jumpItems = new List<JumpItem>(items);
			}
			else
			{
				this._jumpItems = new List<JumpItem>();
			}
			this.ShowFrequentCategory = showFrequent;
			this.ShowRecentCategory = showRecent;
			this._initializing = new bool?(false);
		}

		[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "BeginInit")]
		public void BeginInit()
		{
			if (!this._IsUnmodified)
			{
				throw new InvalidOperationException("Calls to BeginInit cannot be nested.");
			}
			this._initializing = new bool?(true);
		}

		[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "EndInit"), SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "BeginInit")]
		public void EndInit()
		{
			if (this._initializing != true)
			{
				throw new NotSupportedException("Can't call EndInit without first calling BeginInit.");
			}
			this._initializing = new bool?(false);
			this.ApplyFromApplication();
		}

		[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "JumpList"), SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "EndInit")]
		public void Apply()
		{
			if (this._initializing == true)
			{
				throw new InvalidOperationException("The JumpList can't be applied until EndInit has been called.");
			}
			this._initializing = new bool?(false);
			this._ApplyList();
		}

		private void ApplyFromApplication()
		{
			if (this._initializing != true && !this._IsUnmodified)
			{
				this._initializing = new bool?(false);
			}
			if (this._application == Application.Current && this._initializing == false)
			{
				this._ApplyList();
			}
		}

		[SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Standard.Verify.IsApartmentState(System.Threading.ApartmentState,System.String)"), SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes"), SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "JumpLists")]
		private void _ApplyList()
		{
			Verify.IsApartmentState(ApartmentState.STA, "JumpLists can only be effected on STA threads.");
			if (!Utility.IsOSWindows7OrNewer)
			{
				this.RejectEverything();
				return;
			}
			List<JumpItem> jumpItems;
			List<JumpList._RejectedJumpItemPair> list;
			List<JumpList._ShellObjectPair> list2;
			try
			{
				this._BuildShellLists(out jumpItems, out list, out list2);
			}
			catch (Exception)
			{
				this.RejectEverything();
				return;
			}
			this._jumpItems = jumpItems;
			EventHandler<JumpItemsRejectedEventArgs> jumpItemsRejected = this.JumpItemsRejected;
			EventHandler<JumpItemsRemovedEventArgs> jumpItemsRemovedByUser = this.JumpItemsRemovedByUser;
			if (list.Count > 0 && jumpItemsRejected != null)
			{
				List<JumpItem> list3 = new List<JumpItem>(list.Count);
				List<JumpItemRejectionReason> list4 = new List<JumpItemRejectionReason>(list.Count);
				foreach (JumpList._RejectedJumpItemPair current in list)
				{
					list3.Add(current.JumpItem);
					list4.Add(current.Reason);
				}
				jumpItemsRejected(this, new JumpItemsRejectedEventArgs(list3, list4));
			}
			if (list2.Count > 0 && jumpItemsRemovedByUser != null)
			{
				List<JumpItem> list5 = new List<JumpItem>(list2.Count);
				foreach (JumpList._ShellObjectPair current2 in list2)
				{
					if (current2.JumpItem != null)
					{
						list5.Add(current2.JumpItem);
					}
				}
				if (list5.Count > 0)
				{
					jumpItemsRemovedByUser(this, new JumpItemsRemovedEventArgs(list5));
				}
			}
		}

		private void _BuildShellLists(out List<JumpItem> successList, out List<JumpList._RejectedJumpItemPair> rejectedList, out List<JumpList._ShellObjectPair> removedList)
		{
			List<List<JumpList._ShellObjectPair>> list = null;
			removedList = null;
			ICustomDestinationList customDestinationList = CLSID.CoCreateInstance<ICustomDestinationList>("77f10cf0-3db5-4966-b520-b7c54fd35ed6");
			try
			{
				string runtimeId = JumpList._RuntimeId;
				if (!string.IsNullOrEmpty(runtimeId))
				{
					customDestinationList.SetAppID(runtimeId);
				}
				Guid guid = new Guid("92CA9DCD-5622-4bba-A805-5E9F541BD8C9");
				uint num;
				IObjectArray shellObjects = (IObjectArray)customDestinationList.BeginList(out num, ref guid);
				removedList = JumpList.GenerateJumpItems(shellObjects);
				successList = new List<JumpItem>(this.JumpItems.Count);
				rejectedList = new List<JumpList._RejectedJumpItemPair>(this.JumpItems.Count);
				list = new List<List<JumpList._ShellObjectPair>>
				{
					new List<JumpList._ShellObjectPair>()
				};
				foreach (JumpItem current in this.JumpItems)
				{
					if (current == null)
					{
						rejectedList.Add(new JumpList._RejectedJumpItemPair
						{
							JumpItem = current,
							Reason = JumpItemRejectionReason.InvalidItem
						});
					}
					else
					{
						object obj = null;
						try
						{
							obj = JumpList.GetShellObjectForJumpItem(current);
							if (obj == null)
							{
								rejectedList.Add(new JumpList._RejectedJumpItemPair
								{
									Reason = JumpItemRejectionReason.InvalidItem,
									JumpItem = current
								});
							}
							else if (JumpList.ListContainsShellObject(removedList, obj))
							{
								rejectedList.Add(new JumpList._RejectedJumpItemPair
								{
									Reason = JumpItemRejectionReason.RemovedByUser,
									JumpItem = current
								});
							}
							else
							{
								JumpList._ShellObjectPair item = new JumpList._ShellObjectPair
								{
									JumpItem = current,
									ShellObject = obj
								};
								if (string.IsNullOrEmpty(current.CustomCategory))
								{
									list[0].Add(item);
								}
								else
								{
									bool flag = false;
									foreach (List<JumpList._ShellObjectPair> current2 in list)
									{
										if (current2.Count > 0 && current2[0].JumpItem.CustomCategory == current.CustomCategory)
										{
											current2.Add(item);
											flag = true;
											break;
										}
									}
									if (!flag)
									{
										list.Add(new List<JumpList._ShellObjectPair>
										{
											item
										});
									}
								}
								obj = null;
							}
						}
						finally
						{
							Utility.SafeRelease<object>(ref obj);
						}
					}
				}
				list.Reverse();
				if (this.ShowFrequentCategory)
				{
					customDestinationList.AppendKnownCategory(KDC.FREQUENT);
				}
				if (this.ShowRecentCategory)
				{
					customDestinationList.AppendKnownCategory(KDC.RECENT);
				}
				foreach (List<JumpList._ShellObjectPair> current3 in list)
				{
					if (current3.Count > 0)
					{
						string customCategory = current3[0].JumpItem.CustomCategory;
						JumpList.AddCategory(customDestinationList, customCategory, current3, successList, rejectedList);
					}
				}
				customDestinationList.CommitList();
				successList.Reverse();
			}
			finally
			{
				Utility.SafeRelease<ICustomDestinationList>(ref customDestinationList);
				if (list != null)
				{
					foreach (List<JumpList._ShellObjectPair> current4 in list)
					{
						JumpList._ShellObjectPair.ReleaseShellObjects(current4);
					}
				}
				JumpList._ShellObjectPair.ReleaseShellObjects(removedList);
			}
		}

		private static bool ListContainsShellObject(List<JumpList._ShellObjectPair> removedList, object shellObject)
		{
			if (removedList.Count == 0)
			{
				return false;
			}
			IShellItem shellItem = shellObject as IShellItem;
			if (shellItem != null)
			{
				foreach (JumpList._ShellObjectPair current in removedList)
				{
					IShellItem shellItem2 = current.ShellObject as IShellItem;
					if (shellItem2 != null && shellItem.Compare(shellItem2, (SICHINT)805306368u) == 0)
					{
						bool result = true;
						return result;
					}
				}
				return false;
			}
			IShellLinkW shellLinkW = shellObject as IShellLinkW;
			if (shellLinkW != null)
			{
				foreach (JumpList._ShellObjectPair current2 in removedList)
				{
					IShellLinkW shellLinkW2 = current2.ShellObject as IShellLinkW;
					if (shellLinkW2 != null)
					{
						string a = JumpList.ShellLinkToString(shellLinkW2);
						string b = JumpList.ShellLinkToString(shellLinkW);
						if (a == b)
						{
							bool result = true;
							return result;
						}
					}
				}
				return false;
			}
			return false;
		}

		private static object GetShellObjectForJumpItem(JumpItem jumpItem)
		{
			JumpPath jumpPath = jumpItem as JumpPath;
			JumpTask jumpTask = jumpItem as JumpTask;
			if (jumpPath != null)
			{
				return JumpList.CreateItemFromJumpPath(jumpPath);
			}
			if (jumpTask != null)
			{
				return JumpList.CreateLinkFromJumpTask(jumpTask, true);
			}
			return null;
		}

		private static List<JumpList._ShellObjectPair> GenerateJumpItems(IObjectArray shellObjects)
		{
			List<JumpList._ShellObjectPair> list = new List<JumpList._ShellObjectPair>();
			Guid guid = new Guid("00000000-0000-0000-C000-000000000046");
			uint count = shellObjects.GetCount();
			for (uint num = 0u; num < count; num += 1u)
			{
				object at = shellObjects.GetAt(num, ref guid);
				JumpItem jumpItem = null;
				try
				{
					jumpItem = JumpList.GetJumpItemForShellObject(at);
				}
				catch (Exception ex)
				{
					if (ex is NullReferenceException || ex is SEHException)
					{
						throw;
					}
				}
				list.Add(new JumpList._ShellObjectPair
				{
					ShellObject = at,
					JumpItem = jumpItem
				});
			}
			return list;
		}

		private static void AddCategory(ICustomDestinationList cdl, string category, List<JumpList._ShellObjectPair> jumpItems, List<JumpItem> successList, List<JumpList._RejectedJumpItemPair> rejectionList)
		{
			JumpList.AddCategory(cdl, category, jumpItems, successList, rejectionList, true);
		}

		private static void AddCategory(ICustomDestinationList cdl, string category, List<JumpList._ShellObjectPair> jumpItems, List<JumpItem> successList, List<JumpList._RejectedJumpItemPair> rejectionList, bool isHeterogenous)
		{
			IObjectCollection objectCollection = (IObjectCollection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("2d3468c1-36a7-43b6-ac24-d3f02fd9607a")));
			foreach (JumpList._ShellObjectPair current in jumpItems)
			{
				objectCollection.AddObject(current.ShellObject);
			}
			HRESULT hrLeft;
			if (string.IsNullOrEmpty(category))
			{
				hrLeft = cdl.AddUserTasks(objectCollection);
			}
			else
			{
				hrLeft = cdl.AppendCategory(category, objectCollection);
			}
			if (hrLeft.Succeeded)
			{
				int num = jumpItems.Count;
				while (--num >= 0)
				{
					successList.Add(jumpItems[num].JumpItem);
				}
				return;
			}
			if (isHeterogenous && hrLeft == HRESULT.DESTS_E_NO_MATCHING_ASSOC_HANDLER)
			{
				Utility.SafeRelease<IObjectCollection>(ref objectCollection);
				List<JumpList._ShellObjectPair> list = new List<JumpList._ShellObjectPair>();
				foreach (JumpList._ShellObjectPair current2 in jumpItems)
				{
					if (current2.JumpItem is JumpPath)
					{
						rejectionList.Add(new JumpList._RejectedJumpItemPair
						{
							JumpItem = current2.JumpItem,
							Reason = JumpItemRejectionReason.NoRegisteredHandler
						});
					}
					else
					{
						list.Add(current2);
					}
				}
				if (list.Count > 0)
				{
					JumpList.AddCategory(cdl, category, list, successList, rejectionList, false);
					return;
				}
			}
			else
			{
				foreach (JumpList._ShellObjectPair current3 in jumpItems)
				{
					rejectionList.Add(new JumpList._RejectedJumpItemPair
					{
						JumpItem = current3.JumpItem,
						Reason = JumpItemRejectionReason.InvalidItem
					});
				}
			}
		}

		[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
		private static IShellLinkW CreateLinkFromJumpTask(JumpTask jumpTask, bool allowSeparators)
		{
			if (string.IsNullOrEmpty(jumpTask.Title) && (!allowSeparators || !string.IsNullOrEmpty(jumpTask.CustomCategory)))
			{
				return null;
			}
			IShellLinkW shellLinkW = (IShellLinkW)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00021401-0000-0000-C000-000000000046")));
			IShellLinkW result;
			try
			{
				string path = JumpList._FullName;
				if (!string.IsNullOrEmpty(jumpTask.ApplicationPath))
				{
					path = jumpTask.ApplicationPath;
				}
				shellLinkW.SetPath(path);
				if (!string.IsNullOrEmpty(jumpTask.WorkingDirectory))
				{
					shellLinkW.SetWorkingDirectory(jumpTask.WorkingDirectory);
				}
				if (!string.IsNullOrEmpty(jumpTask.Arguments))
				{
					shellLinkW.SetArguments(jumpTask.Arguments);
				}
				if (jumpTask.IconResourceIndex != -1)
				{
					string pszIconPath = JumpList._FullName;
					if (!string.IsNullOrEmpty(jumpTask.IconResourcePath))
					{
						if ((long)jumpTask.IconResourcePath.Length >= 260L)
						{
							result = null;
							return result;
						}
						pszIconPath = jumpTask.IconResourcePath;
					}
					shellLinkW.SetIconLocation(pszIconPath, jumpTask.IconResourceIndex);
				}
				if (!string.IsNullOrEmpty(jumpTask.Description))
				{
					shellLinkW.SetDescription(jumpTask.Description);
				}
				IPropertyStore propertyStore = (IPropertyStore)shellLinkW;
				using (PROPVARIANT pROPVARIANT = new PROPVARIANT())
				{
					PKEY pKEY = default(PKEY);
					if (!string.IsNullOrEmpty(jumpTask.Title))
					{
						pROPVARIANT.SetValue(jumpTask.Title);
						pKEY = PKEY.Title;
					}
					else
					{
						pROPVARIANT.SetValue(true);
						pKEY = PKEY.AppUserModel_IsDestListSeparator;
					}
					propertyStore.SetValue(ref pKEY, pROPVARIANT);
				}
				propertyStore.Commit();
				IShellLinkW shellLinkW2 = shellLinkW;
				shellLinkW = null;
				result = shellLinkW2;
			}
			catch (Exception)
			{
				result = null;
			}
			finally
			{
				Utility.SafeRelease<IShellLinkW>(ref shellLinkW);
			}
			return result;
		}

		private static IShellItem2 GetShellItemForPath(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return null;
			}
			Guid guid = new Guid("7e9fb0d3-919f-4307-ab2e-9b1860310c93");
			object obj;
			HRESULT hrLeft = NativeMethods.SHCreateItemFromParsingName(path, null, ref guid, out obj);
			if (hrLeft == (HRESULT)Win32Error.ERROR_FILE_NOT_FOUND || hrLeft == (HRESULT)Win32Error.ERROR_PATH_NOT_FOUND)
			{
				hrLeft = HRESULT.S_OK;
				obj = null;
			}
			hrLeft.ThrowIfFailed();
			return (IShellItem2)obj;
		}

		[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
		private static IShellItem2 CreateItemFromJumpPath(JumpPath jumpPath)
		{
			try
			{
				return JumpList.GetShellItemForPath(Path.GetFullPath(jumpPath.Path));
			}
			catch (Exception)
			{
			}
			return null;
		}

		private static JumpItem GetJumpItemForShellObject(object shellObject)
		{
			IShellItem2 shellItem = shellObject as IShellItem2;
			IShellLinkW shellLinkW = shellObject as IShellLinkW;
			if (shellItem != null)
			{
				return new JumpPath
				{
					Path = shellItem.GetDisplayName((SIGDN)2147647488u)
				};
			}
			if (shellLinkW != null)
			{
				StringBuilder stringBuilder = new StringBuilder(260);
				shellLinkW.GetPath(stringBuilder, stringBuilder.Capacity, null, SLGP.RAWPATH);
				StringBuilder stringBuilder2 = new StringBuilder(1024);
				shellLinkW.GetArguments(stringBuilder2, stringBuilder2.Capacity);
				StringBuilder stringBuilder3 = new StringBuilder(1024);
				shellLinkW.GetDescription(stringBuilder3, stringBuilder3.Capacity);
				StringBuilder stringBuilder4 = new StringBuilder(260);
				int iconResourceIndex;
				shellLinkW.GetIconLocation(stringBuilder4, stringBuilder4.Capacity, out iconResourceIndex);
				StringBuilder stringBuilder5 = new StringBuilder(260);
				shellLinkW.GetWorkingDirectory(stringBuilder5, stringBuilder5.Capacity);
				JumpTask jumpTask = new JumpTask
				{
					ApplicationPath = stringBuilder.ToString(),
					Arguments = stringBuilder2.ToString(),
					Description = stringBuilder3.ToString(),
					IconResourceIndex = iconResourceIndex,
					IconResourcePath = stringBuilder4.ToString(),
					WorkingDirectory = stringBuilder5.ToString()
				};
				using (PROPVARIANT pROPVARIANT = new PROPVARIANT())
				{
					IPropertyStore propertyStore = (IPropertyStore)shellLinkW;
					PKEY title = PKEY.Title;
					propertyStore.GetValue(ref title, pROPVARIANT);
					jumpTask.Title = (pROPVARIANT.GetValue() ?? "");
				}
				return jumpTask;
			}
			return null;
		}

		private static string ShellLinkToString(IShellLinkW shellLink)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			shellLink.GetPath(stringBuilder, stringBuilder.Capacity, null, SLGP.RAWPATH);
			string text = null;
			using (PROPVARIANT pROPVARIANT = new PROPVARIANT())
			{
				IPropertyStore propertyStore = (IPropertyStore)shellLink;
				PKEY title = PKEY.Title;
				propertyStore.GetValue(ref title, pROPVARIANT);
				text = (pROPVARIANT.GetValue() ?? "");
			}
			StringBuilder stringBuilder2 = new StringBuilder(1024);
			shellLink.GetArguments(stringBuilder2, stringBuilder2.Capacity);
			return stringBuilder.ToString().ToUpperInvariant() + text.ToUpperInvariant() + stringBuilder2.ToString();
		}

		private void RejectEverything()
		{
			EventHandler<JumpItemsRejectedEventArgs> jumpItemsRejected = this.JumpItemsRejected;
			if (jumpItemsRejected == null)
			{
				this._jumpItems.Clear();
				return;
			}
			if (this._jumpItems.Count > 0)
			{
				List<JumpItemRejectionReason> list = new List<JumpItemRejectionReason>(this.JumpItems.Count);
				for (int i = 0; i < this.JumpItems.Count; i++)
				{
					list.Add(JumpItemRejectionReason.InvalidItem);
				}
				JumpItemsRejectedEventArgs e = new JumpItemsRejectedEventArgs(this.JumpItems, list);
				this._jumpItems.Clear();
				jumpItemsRejected(this, e);
			}
		}
	}
}

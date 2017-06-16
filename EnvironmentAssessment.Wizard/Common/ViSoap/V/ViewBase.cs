using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
namespace EnvironmentAssessment.Common.VISoap
{
	public class ViewBase
	{
		private ManagedObjectReference _moRef;
		private VimClient _client;
		public virtual ManagedObjectReference MoRef
		{
			get
			{
				return this._moRef;
			}
		}
		public virtual VimClient Client
		{
			get
			{
				return this._client;
			}
		}
		public ViewBase(VimClient client, ManagedObjectReference moRef)
		{
			if (moRef == null)
			{
				throw new ArgumentNullException("moRef");
			}
			if (client == null)
			{
				throw new ArgumentNullException("client");
			}
			this._client = client;
			this._moRef = moRef;
		}
		public static PropertySpec[] GetPropertySpec(string typeName)
		{
			return new PropertySpec[]
			{
				new PropertySpec
				{
					All = new bool?(true),
					Type = typeName
				}
			};
		}
		public static PropertyFilterSpec GetPropertyFilterSpec(ManagedObjectReference moRef)
		{
			PropertySpec[] propertySpec = ViewBase.GetPropertySpec(moRef.Type);
			ObjectSpec objectSpec = new ObjectSpec();
			objectSpec.Obj = moRef;
			return new PropertyFilterSpec
			{
				PropSet = propertySpec,
				ObjectSet = new ObjectSpec[]
				{
					objectSpec
				}
			};
		}
		public static Type GetViewType(string typeName)
		{
			Type result;
			if (string.IsNullOrEmpty(typeName))
			{
				result = null;
			}
			else
			{
				string typeName2 = typeof(ViewBase).Namespace + "." + typeName;
				result = Type.GetType(typeName2, false, true);
			}
			return result;
		}
		public void UpdateViewData(params string[] properties)
		{
			PropertyCollector propertyCollector = new PropertyCollector(this._client, this._client.ServiceContent.PropertyCollector);
			PropertyFilterSpec propertyFilterSpec;
			Dictionary<string, List<string>> allowedPropertyPath;
			DynamicPropertyFilterSpecGenerator.Generate(this.MoRef, VimClient.MakePropertiesCamelCase(properties), out propertyFilterSpec, out allowedPropertyPath);
			ObjectContent[] array = propertyCollector.RetrieveProperties(new PropertyFilterSpec[]
			{
				propertyFilterSpec
			});
			Dictionary<string, ObjectContent> dictionary = new Dictionary<string, ObjectContent>();
			ObjectContent[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				ObjectContent objectContent = array2[i];
				dictionary.Add(objectContent.Obj.Value, objectContent);
			}
			Dictionary<string, ViewBase> generatedManagedObjectList = new Dictionary<string, ViewBase>();
			if (properties != null)
			{
				new List<string>(properties);
			}
			ViewBase.SetViewData(this, null, allowedPropertyPath, dictionary, generatedManagedObjectList);
		}
		public void UpdateViewData()
		{
			this.UpdateViewData(null);
		}
		public void SetViewData(ObjectContent objectContent, string[] properties)
		{
			Dictionary<string, ObjectContent> dictionary = new Dictionary<string, ObjectContent>();
			dictionary.Add(objectContent.Obj.Value, objectContent);
			Dictionary<string, ViewBase> generatedManagedObjectList = new Dictionary<string, ViewBase>();
			PropertyFilterSpec propertyFilterSpec;
			Dictionary<string, List<string>> allowedPropertyPath;
			DynamicPropertyFilterSpecGenerator.Generate(objectContent.Obj, properties, out propertyFilterSpec, out allowedPropertyPath);
			ViewBase.SetViewData(this, null, allowedPropertyPath, dictionary, generatedManagedObjectList);
		}
		internal static void SetViewData(ViewBase currentObject, string currentPropertyPath, Dictionary<string, List<string>> allowedPropertyPath, Dictionary<string, ObjectContent> objectContentList, Dictionary<string, ViewBase> generatedManagedObjectList)
		{
			if (currentPropertyPath == null)
			{
				currentPropertyPath = string.Empty;
			}
			if (!objectContentList.ContainsKey(currentObject.MoRef.Value))
			{
				return;
			}
			if (!generatedManagedObjectList.ContainsKey(currentObject.MoRef.Value))
			{
				generatedManagedObjectList.Add(currentObject.MoRef.Value, currentObject);
			}
			ObjectContent objectContent = objectContentList[currentObject.MoRef.Value];
			if (allowedPropertyPath != null)
			{
				ViewBase.ClearViewData(currentObject, currentPropertyPath, new List<string>(allowedPropertyPath.Keys));
			}
			else
			{
				ViewBase.ClearViewData(currentObject, currentPropertyPath, null);
			}
			if (objectContent.PropSet != null)
			{
				DynamicProperty[] propSet = objectContent.PropSet;
				DynamicProperty[] array = propSet;
				int i = 0;
				while (i < array.Length)
				{
					DynamicProperty dynamicProperty = array[i];
					bool flag = false;
					string text = string.Empty;
					if (allowedPropertyPath == null)
					{
						goto IL_231;
					}
					text = string.Format("{0}{1}{2}", currentPropertyPath, (currentPropertyPath != "") ? "." : "", dynamicProperty.Name.ToLower());
					string value = string.Format("{0}{1}{2}", currentPropertyPath, (currentPropertyPath != "") ? "." : "", "*");
					bool flag2 = false;
					bool flag3 = false;
					foreach (string current in allowedPropertyPath.Keys)
					{
						if (current.StartsWith(text))
						{
							flag2 = true;
						}
						if (current.Equals(value))
						{
							List<string> list = new List<string>();
							if (allowedPropertyPath.ContainsKey(currentPropertyPath))
							{
								list.AddRange(allowedPropertyPath[currentPropertyPath]);
							}
							else
							{
								if (allowedPropertyPath.ContainsKey(currentPropertyPath + "->"))
								{
									list.AddRange(allowedPropertyPath[currentPropertyPath + "->"]);
								}
							}
							foreach (string current2 in list)
							{
								Dictionary<string, PropertyInfo> typeProperties = ViReflectionCache.GetTypeProperties(ViReflectionCache.GetTypeByRemoteTypeAndName(typeof(ManagedObjectReference), current2));
								if (typeProperties.ContainsKey(dynamicProperty.Name.ToLower()))
								{
									flag3 = true;
									break;
								}
							}
						}
						if (current.Equals(text))
						{
							flag3 = true;
						}
						if (flag2 && flag3)
						{
							break;
						}
					}
					if (!flag3 && flag2)
					{
						flag = true;
					}
					if (flag3 || flag2)
					{
						goto IL_231;
					}
					IL_4DB:
					i++;
					continue;
					IL_231:
					string[] array2 = dynamicProperty.Name.Split(new char[]
					{
						'.'
					});
					Type type = currentObject.GetType();
					object obj = currentObject;
					FieldInfo field;
					for (int j = 0; j < array2.Length - 1; j++)
					{
						string name = "_" + array2[j];
						field = type.GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
						object obj2 = field.GetValue(obj);
						type = field.FieldType;
						if (obj2 == null)
						{
							obj2 = type.GetConstructor(Type.EmptyTypes).Invoke(null);
							field.SetValue(obj, obj2);
						}
						obj = obj2;
					}
					field = type.GetField("_" + array2[array2.Length - 1], BindingFlags.Instance | BindingFlags.NonPublic);
					if (!flag)
					{
						field.SetValue(obj, dynamicProperty.Val);
					}
					ManagedObjectReference[] array3 = null;
					if (field.FieldType == typeof(ManagedObjectReference))
					{
						array3 = new ManagedObjectReference[]
						{
							(ManagedObjectReference)dynamicProperty.Val
						};
					}
					else
					{
						if (field.FieldType == typeof(ManagedObjectReference[]))
						{
							List<string> list2 = new List<string>();
							if (allowedPropertyPath != null)
							{
								if (allowedPropertyPath.ContainsKey(text) && allowedPropertyPath[text] != null)
								{
									list2.AddRange(allowedPropertyPath[text]);
								}
								if (allowedPropertyPath.ContainsKey(text + "->") && allowedPropertyPath[text + "->"] != null)
								{
									list2.AddRange(allowedPropertyPath[text + "->"]);
								}
							}
							List<ManagedObjectReference> list3 = new List<ManagedObjectReference>();
							ManagedObjectReference[] array4 = (ManagedObjectReference[])dynamicProperty.Val;
							for (int k = 0; k < array4.Length; k++)
							{
								ManagedObjectReference managedObjectReference = array4[k];
								if (list2.Count == 0 || list2.Contains(managedObjectReference.Type))
								{
									list3.Add(managedObjectReference);
								}
								else
								{
									foreach (string current3 in list2)
									{
										Type typeByRemoteTypeAndName = ViReflectionCache.GetTypeByRemoteTypeAndName(typeof(ManagedObjectReference), managedObjectReference.Type);
										Type typeByRemoteTypeAndName2 = ViReflectionCache.GetTypeByRemoteTypeAndName(typeof(ManagedObjectReference), current3);
										if (typeByRemoteTypeAndName2.IsAssignableFrom(typeByRemoteTypeAndName))
										{
											list3.Add(managedObjectReference);
											break;
										}
									}
								}
							}
							array3 = list3.ToArray();
						}
					}
					if (array3 == null)
					{
						goto IL_4DB;
					}
					string text2 = string.Format("{0}{1}{2}", currentPropertyPath, (currentPropertyPath != "") ? "." : "", dynamicProperty.Name.ToLower());
					if (ViewBase.IsNonTerminalPath(allowedPropertyPath, text2))
					{
						ViewBase.SetExtView(obj, field.Name, currentObject._client, array3, objectContentList, generatedManagedObjectList, text2, allowedPropertyPath);
						goto IL_4DB;
					}
					goto IL_4DB;
				}
				return;
			}
			if (objectContent.MissingSet != null && objectContent.MissingSet.Length > 0)
			{
				MethodFault fault = objectContent.MissingSet[0].Fault.Fault;
				string localizedMessage = objectContent.MissingSet[0].Fault.LocalizedMessage;
				throw new VimException(localizedMessage, fault);
			}
		}
		private static bool IsNonTerminalPath(Dictionary<string, List<string>> allowedPropertyPaths, string tempPropertyPath)
		{
			bool result = false;
			if (allowedPropertyPaths != null)
			{
				foreach (string current in allowedPropertyPaths.Keys)
				{
					if (current.StartsWith(tempPropertyPath) && current != tempPropertyPath)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}
		private static void SetExtView(object currentObject, string moPropertyName, VimClient client, ManagedObjectReference[] moList, Dictionary<string, ObjectContent> objectContentList, Dictionary<string, ViewBase> generatedManagedObjectList, string currentPropertyPath, Dictionary<string, List<string>> allowedPropertyPath)
		{
			ArrayList arrayList = new ArrayList();
			bool flag = false;
			if (moList.Length == 0)
			{
				flag = true;
			}
			FieldInfo field = currentObject.GetType().GetField("_linkedView", BindingFlags.Instance | BindingFlags.NonPublic);
			Dictionary<string, PropertyInfo> typeProperties = ViReflectionCache.GetTypeProperties(currentObject.GetType());
			PropertyInfo propertyInfo = null;
			typeProperties.TryGetValue("LinkedView".ToLower(), out propertyInfo);
			FieldInfo field2 = propertyInfo.PropertyType.GetField(moPropertyName, BindingFlags.Instance | BindingFlags.NonPublic);
			bool isArray = field2.FieldType.IsArray;
			Type type = isArray ? field2.FieldType.GetElementType() : field2.FieldType;
			for (int i = 0; i < moList.Length; i++)
			{
				ManagedObjectReference managedObjectReference = moList[i];
				if (objectContentList.ContainsKey(managedObjectReference.Value) || generatedManagedObjectList.ContainsKey(managedObjectReference.Value))
				{
					object obj;
					if (generatedManagedObjectList.ContainsKey(managedObjectReference.Value))
					{
						obj = generatedManagedObjectList[managedObjectReference.Value];
					}
					else
					{
						Type viewType = ViewBase.GetViewType(managedObjectReference.Type);
						obj = viewType.GetConstructor(new Type[]
						{
							typeof(VimClient),
							typeof(ManagedObjectReference)
						}).Invoke(new object[]
						{
							client,
							managedObjectReference
						});
					}
					ViewBase.SetViewData((ViewBase)obj, currentPropertyPath, allowedPropertyPath, objectContentList, generatedManagedObjectList);
					arrayList.Add(obj);
				}
			}
			if (flag || arrayList.Count > 0)
			{
				object obj2 = propertyInfo.GetValue(currentObject, null);
				if (obj2 == null)
				{
					obj2 = ViReflectionCache.GetTypeDefaultConstructor(propertyInfo.PropertyType).Invoke(null);
				}
				field.SetValue(currentObject, obj2);
				if (!isArray)
				{
					field2.SetValue(obj2, arrayList[0]);
					return;
				}
				field2.SetValue(obj2, arrayList.ToArray(type));
			}
		}
		[Obsolete("Use VimClient.WaitForTask instead")]
		public object WaitForTask(ManagedObjectReference taskReference)
		{
			return this._client.WaitForTask(taskReference);
		}
		private static void ClearViewData(ViewBase currentObject, string currentPath, List<string> properties)
		{
			properties = ViewBase.GetCurrentProperties(currentPath, properties);
			if (properties.Count > 0)
			{
				using (List<string>.Enumerator enumerator = properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						string[] array = current.Split(new char[]
						{
							'.'
						});
						Type type = currentObject.GetType();
						object obj = currentObject;
						bool flag = false;
						for (int i = 0; i < array.Length - 1; i++)
						{
							string name = "_" + array[i];
							FieldInfo field = type.GetField(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
							if (field != null)
							{
								if (field.FieldType == typeof(ManagedObjectReference) && i <= array.Length - 2)
								{
									ViewBase.ClearExtView(obj);
								}
								object value = field.GetValue(obj);
								type = field.FieldType;
								if (value == null)
								{
									flag = true;
									break;
								}
								obj = value;
							}
						}
						if (!flag)
						{
							FieldInfo field = type.GetField("_" + array[array.Length - 1], BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
							if (field != null)
							{
								ViewBase.ClearField(obj, field);
							}
						}
					}
					return;
				}
			}
			ManagedObjectReference moRef = currentObject._moRef;
			VimClient client = currentObject._client;
			FieldInfo[] fields = currentObject.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo[] array2 = fields;
			for (int j = 0; j < array2.Length; j++)
			{
				FieldInfo field2 = array2[j];
				ViewBase.ClearField(currentObject, field2);
			}
			currentObject._moRef = moRef;
			currentObject._client = client;
		}
		private static void ClearExtView(object obj)
		{
			PropertyInfo property = obj.GetType().GetProperty("LinkedView", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
			FieldInfo field = obj.GetType().GetField("_linkedView", BindingFlags.Instance | BindingFlags.NonPublic);
			if (property.GetValue(obj, null) == null)
			{
				object value = ViReflectionCache.GetTypeDefaultConstructor(property.PropertyType).Invoke(null);
				field.SetValue(obj, value);
			}
		}
		private static List<string> GetCurrentProperties(string currentPath, List<string> properties)
		{
			List<string> list = new List<string>();
			if (properties != null)
			{
				foreach (string current in properties)
				{
					if (currentPath != current && current.StartsWith(currentPath) && !current.EndsWith("->"))
					{
						list.Add(current.Substring(currentPath.Length));
					}
				}
			}
			return list;
		}
		private static void ClearField(object obj, FieldInfo field)
		{
			if (field.GetType().IsValueType)
			{
				field.SetValue(obj, Activator.CreateInstance(field.GetType()));
				return;
			}
			field.SetValue(obj, null);
		}
	}
}

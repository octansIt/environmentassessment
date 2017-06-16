using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
namespace EnvironmentAssessment.Common.VISoap
{
    public class VIConvert
	{
		private static string _namespaceVim60;
		private static Assembly _assemblyVim60;
		private static string _namespaceVim;
		private static Assembly _assemblyVim;
		internal static string NamespaceVim
		{
			[DebuggerStepThrough]
			get
			{
				if (string.IsNullOrEmpty(VIConvert._namespaceVim))
				{
					VIConvert._namespaceVim = typeof(ManagedObjectReference).Namespace;
				}
				return VIConvert._namespaceVim;
			}
		}
		internal static Assembly AssemblyVim
		{
			[DebuggerStepThrough]
			get
			{
				if (VIConvert._assemblyVim == null)
				{
					VIConvert._assemblyVim = typeof(ManagedObjectReference).Assembly;
				}
				return VIConvert._assemblyVim;
			}
		}
		private static string NamespaceVim60
		{
			get
			{
				if (string.IsNullOrEmpty(VIConvert._namespaceVim60))
				{
					VIConvert._namespaceVim60 = typeof(VimApi_60.ManagedObjectReference).Namespace;
				}
				return VIConvert._namespaceVim60;
			}
		}
		private static Assembly AssemblyVim60
		{
			get
			{
				if (VIConvert._assemblyVim60 == null)
				{
					VIConvert._assemblyVim60 = typeof(VimApi_60.ManagedObjectReference).Assembly;
				}
				return VIConvert._assemblyVim60;
			}
		}
		private static object Convert(object source, string targetNamespace, Assembly targetAssembly)
		{
			object result = null;
			if (source != null)
			{
				Type type = source.GetType();
				string name = targetNamespace + "." + type.Name;
				Type type2 = targetAssembly.GetType(name, true);
				result = VIConvert.Convert(source, type, type2);
			}
			return result;
		}
		private static object Convert(object source, Type sourceType, Type resultType)
		{
			object obj = null;
			if (sourceType == null)
			{
				MethodBase.GetCurrentMethod();
				throw new ArgumentNullException("resultType");
			}
			if (resultType == null)
			{
				MethodBase.GetCurrentMethod();
				throw new ArgumentNullException("resultType");
			}
			if (!resultType.Name.Equals(sourceType.Name))
			{
				MethodBase.GetCurrentMethod();
				string message = string.Format(Resources.InvalidObjectType, sourceType.FullName, resultType.FullName);
				throw new InvalidOperationException(message);
			}
			if (source != null)
			{
				if (sourceType == resultType)
				{
					obj = source;
				}
				else
				{
					if (sourceType.IsArray)
					{
						Array array = (Array)source;
						ArrayList arrayList = new ArrayList();
						for (int i = 0; i < array.Length; i++)
						{
							object value = array.GetValue(i);
							if (value != null)
							{
								Type type = value.GetType();
								Type typeByRemoteTypeAndName = ViReflectionCache.GetTypeByRemoteTypeAndName(resultType, type.Name);
								if (typeByRemoteTypeAndName != null)
								{
									arrayList.Add(VIConvert.Convert(value, type, typeByRemoteTypeAndName));
								}
							}
						}
						obj = arrayList.ToArray(resultType.GetElementType());
					}
					else
					{
						if (sourceType.IsEnum)
						{
							obj = Enum.Parse(resultType, source.ToString(), true);
						}
						else
						{
							ConstructorInfo typeDefaultConstructor = ViReflectionCache.GetTypeDefaultConstructor(resultType);
							if (typeDefaultConstructor != null)
							{
								obj = typeDefaultConstructor.Invoke(new object[0]);
								Dictionary<string, PropertyInfo> typeProperties = ViReflectionCache.GetTypeProperties(sourceType);
								Dictionary<string, PropertyInfo> typeProperties2 = ViReflectionCache.GetTypeProperties(resultType);
								foreach (KeyValuePair<string, PropertyInfo> current in typeProperties)
								{
									PropertyInfo propertyInfo;
									typeProperties2.TryGetValue(current.Key, out propertyInfo);
									if (propertyInfo != null)
									{
										object value2 = current.Value.GetValue(source, null);
										if (value2 != null)
										{
											Type type2 = value2.GetType();
											object value3 = null;
											Type typeByRemoteTypeAndName2 = ViReflectionCache.GetTypeByRemoteTypeAndName(resultType, type2.Name);
											if (typeByRemoteTypeAndName2 != null)
											{
												value3 = VIConvert.Convert(value2, type2, typeByRemoteTypeAndName2);
											}
											bool flag = true;
											if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
											{
												PropertyInfo propertyInfo2;
												typeProperties.TryGetValue(current.Key + "specified", out propertyInfo2);
												if (propertyInfo2 != null)
												{
													flag = (bool)propertyInfo2.GetValue(source, null);
												}
											}
											if (flag)
											{
												if (type2.Namespace.Equals(sourceType.Namespace))
												{
													propertyInfo.SetValue(obj, value3, null);
												}
												else
												{
													propertyInfo.SetValue(obj, value2, null);
												}
											}
										}
										if (!propertyInfo.PropertyType.IsByRef)
										{
											PropertyInfo propertyInfo3;
											typeProperties2.TryGetValue(propertyInfo.Name.ToLower() + "specified", out propertyInfo3);
											if (propertyInfo3 != null)
											{
												propertyInfo3.SetValue(obj, value2 != null, null);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return obj;
		}
		public static object ToVim(object source)
		{
			return VIConvert.Convert(source, VIConvert.NamespaceVim, VIConvert.AssemblyVim);
		}
		public static object ToWsdlType(object source)
		{
			return VIConvert.Convert(source, VIConvert.NamespaceVim60, VIConvert.AssemblyVim60);
		}
	}
}

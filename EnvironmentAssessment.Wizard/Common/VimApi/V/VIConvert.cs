using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class VIConvert
	{
		private static string _namespaceVim65;
		private static Assembly _assemblyVim65;
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
		private static string NamespaceVim65
		{
			get
			{
				if (string.IsNullOrEmpty(VIConvert._namespaceVim65))
				{
					VIConvert._namespaceVim65 = typeof(VimApi_65.ManagedObjectReference).Namespace;
				}
				return VIConvert._namespaceVim65;
			}
		}
		private static Assembly AssemblyVim65
		{
			get
			{
				if (VIConvert._assemblyVim65 == null)
				{
					VIConvert._assemblyVim65 = typeof(VimApi_65.ManagedObjectReference).Assembly;
				}
				return VIConvert._assemblyVim65;
			}
		}
		private static object Convert(object source, string targetNamespace, Assembly targetAssembly)
		{
			object result = null;
			if (source != null)
			{
				TypeInfo typeInfo = source.GetType().GetTypeInfo();
				string name = targetNamespace + "." + typeInfo.Name;
				Type type = targetAssembly.GetType(name, true);
				result = VIConvert.Convert(source, typeInfo, type);
			}
			return result;
		}
		private static object Convert(object source, Type sourceType, Type resultType)
		{
			object obj = null;
			if (source.GetType().GetTypeInfo().FullName == "VMware.Vim.SecurePasswordField")
			{
				source = ((SecurePasswordField)source).ToPasswordField();
				sourceType = source.GetType();
			}
			if (sourceType == null)
			{
				throw new ArgumentNullException("resultType");
			}
			if (resultType == null)
			{
				throw new ArgumentNullException("resultType");
			}
			if (!resultType.Name.Equals(sourceType.Name))
			{
				throw new InvalidOperationException(string.Format(Resources.InvalidObjectType, sourceType.FullName, resultType.FullName));
			}
			if (source != null)
			{
				if (sourceType == resultType)
				{
					obj = source;
				}
				else if (sourceType.GetTypeInfo().IsArray)
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
				else if (sourceType.IsEnum)
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
									string typeName = type2.Name;
									if (type2.GetTypeInfo().FullName == "VMware.Vim.SecurePasswordField")
									{
										typeName = "PasswordField";
									}
									Type typeByRemoteTypeAndName2 = ViReflectionCache.GetTypeByRemoteTypeAndName(resultType, typeName);
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
			if (obj.GetType().GetTypeInfo().FullName == "VMware.Vim.PasswordField")
			{
				obj = new SecurePasswordField(obj as PasswordField);
			}
			return obj;
		}
		public static object ToVim(object source)
		{
			return VIConvert.Convert(source, VIConvert.NamespaceVim, VIConvert.AssemblyVim);
		}
		public static object ToWsdlType(object source)
		{
			return VIConvert.Convert(source, VIConvert.NamespaceVim65, VIConvert.AssemblyVim65);
		}
	}
}

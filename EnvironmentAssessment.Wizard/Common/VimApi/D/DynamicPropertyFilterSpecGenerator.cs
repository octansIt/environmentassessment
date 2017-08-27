using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
namespace EnvironmentAssessment.Common.VimApi
{
	internal sealed class DynamicPropertyFilterSpecGenerator
	{
		private class ManagedObjectDefinition
		{
			private string _objectType;
			private string _propertyPath;
			public string ObjectType
			{
				get
				{
					return this._objectType;
				}
				set
				{
					this._objectType = value;
				}
			}
			public string PropertyPath
			{
				get
				{
					return this._propertyPath;
				}
				set
				{
					this._propertyPath = value;
				}
			}
		}
		private class PropertyDefinition
		{
			private string _name;
			private string _objectType;
			private DynamicPropertyFilterSpecGenerator.VimType _vimType;
			public string Name
			{
				get
				{
					return this._name;
				}
				set
				{
					this._name = value;
				}
			}
			public string ObjectType
			{
				get
				{
					return this._objectType;
				}
				set
				{
					this._objectType = value;
				}
			}
			public DynamicPropertyFilterSpecGenerator.VimType VimType
			{
				get
				{
					return this._vimType;
				}
				set
				{
					this._vimType = value;
				}
			}
		}
		private enum VimType
		{
			Unknown,
			ManagedObject,
			DataObject
		}
		private const string TYPE_GROUP_NAME = "type";
		private const string NAME_GROUP_NAME = "name";
		private static readonly Regex PROPERTY_PATH_REGEX = new Regex(string.Format("(\\[(?<{0}>\\w*)\\])?(?<{1}>[\\w*]+)\\.?", "type", "name"), RegexOptions.Compiled);
		private static readonly Regex PROPERTY_PATH_VALIDATION_REGEX = new Regex("^((\\[\\w*\\])?[\\w*]+\\.?)*$", RegexOptions.Compiled);
		internal static void Generate(ManagedObjectReference startingObject, string[] propertyPathList, out PropertyFilterSpec resultPropertyFilterSpec, out Dictionary<string, List<string>> currentAllowedPropertyPath)
		{
			resultPropertyFilterSpec = new PropertyFilterSpec();
			ObjectSpec objectSpec = new ObjectSpec();
			resultPropertyFilterSpec.ObjectSet = new ObjectSpec[]
			{
				objectSpec
			};
			objectSpec.Obj = startingObject;
			objectSpec.SelectSet = new SelectionSpec[0];
			resultPropertyFilterSpec.PropSet = new PropertySpec[0];
			currentAllowedPropertyPath = null;
			if (propertyPathList == null)
			{
				PropertySpec propertySpec = new PropertySpec();
				propertySpec.Type = startingObject.Type;
				propertySpec.All = new bool?(true);
				resultPropertyFilterSpec.PropSet = new PropertySpec[]
				{
					propertySpec
				};
				return;
			}
			currentAllowedPropertyPath = new Dictionary<string, List<string>>();
			for (int i = 0; i < propertyPathList.Length; i++)
			{
				DynamicPropertyFilterSpecGenerator.PropertyDefinition[] array = DynamicPropertyFilterSpecGenerator.ParsePropertyPath(propertyPathList[i]);
				List<DynamicPropertyFilterSpecGenerator.PropertyDefinition> list = new List<DynamicPropertyFilterSpecGenerator.PropertyDefinition>(array);
				DynamicPropertyFilterSpecGenerator.SetPropertyTypesAndFixCasing(array, startingObject.Type);
				DynamicPropertyFilterSpecGenerator.GenerateAllowedPropertyPath(ref currentAllowedPropertyPath, list.ToArray(), array);
				List<DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition> list2 = DynamicPropertyFilterSpecGenerator.GenerateManagedObjectList(array, startingObject.Type);
				DynamicPropertyFilterSpecGenerator.GeneratePropertySet(ref resultPropertyFilterSpec, list2);
				resultPropertyFilterSpec.ObjectSet[0].SelectSet = DynamicPropertyFilterSpecGenerator.GenerateSelectionSet(resultPropertyFilterSpec.ObjectSet[0].SelectSet, list2.GetEnumerator(), list2.Count);
			}
		}
		private static void GenerateAllowedPropertyPath(ref Dictionary<string, List<string>> allowedPropertyPath, DynamicPropertyFilterSpecGenerator.PropertyDefinition[] userSpecifiedPropertyList, DynamicPropertyFilterSpecGenerator.PropertyDefinition[] fixedPropertyList)
		{
			string text = "";
			int num = userSpecifiedPropertyList.Length;
			for (int i = 0; i < userSpecifiedPropertyList.Length; i++)
			{
				DynamicPropertyFilterSpecGenerator.PropertyDefinition propertyDefinition = (userSpecifiedPropertyList[i].ObjectType != null) ? userSpecifiedPropertyList[i] : fixedPropertyList[i];
				if (propertyDefinition.ObjectType != null)
				{
					propertyDefinition.ObjectType = DynamicPropertyFilterSpecGenerator.FixTypeName(propertyDefinition.ObjectType);
				}
				text = string.Format("{0}{1}{2}", text, (text != string.Empty) ? "." : "", propertyDefinition.Name.ToLower());
				string text2 = string.Format("{0}->", text);
				if (allowedPropertyPath.ContainsKey(text))
				{
					if (!allowedPropertyPath[text].Contains(propertyDefinition.ObjectType))
					{
						allowedPropertyPath[text].Add(propertyDefinition.ObjectType);
					}
				}
				else if (allowedPropertyPath.ContainsKey(text2))
				{
					if (propertyDefinition.ObjectType != null && !allowedPropertyPath[text2].Contains(propertyDefinition.ObjectType))
					{
						allowedPropertyPath[text2].Add(propertyDefinition.ObjectType);
					}
					if (num == 1)
					{
						List<string> value = allowedPropertyPath[text2];
						allowedPropertyPath.Remove(text2);
						allowedPropertyPath.Add(text, value);
					}
				}
				else
				{
					string key = (num == 1) ? text : text2;
					allowedPropertyPath[key] = new List<string>();
					if (propertyDefinition.ObjectType != null)
					{
						allowedPropertyPath[key].Add(propertyDefinition.ObjectType);
					}
				}
				num--;
			}
		}
		private static SelectionSpec[] GenerateSelectionSet(IEnumerable<SelectionSpec> selectionSet, IEnumerator<DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition> moListIterator, int reverseCounter)
		{
			List<SelectionSpec> list = (selectionSet != null) ? new List<SelectionSpec>(selectionSet) : new List<SelectionSpec>();
			if (reverseCounter != 1)
			{
				moListIterator.MoveNext();
				TraversalSpec traversalSpec = null;
				using (List<SelectionSpec>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						TraversalSpec traversalSpec2 = (TraversalSpec)enumerator.Current;
						if (moListIterator.Current.ObjectType == traversalSpec2.Type && moListIterator.Current.PropertyPath == traversalSpec2.Path)
						{
							traversalSpec = traversalSpec2;
							break;
						}
					}
				}
				if (traversalSpec != null)
				{
					traversalSpec.SelectSet = DynamicPropertyFilterSpecGenerator.GenerateSelectionSet(traversalSpec.SelectSet, moListIterator, --reverseCounter);
				}
				else
				{
					traversalSpec = new TraversalSpec();
					traversalSpec.Type = DynamicPropertyFilterSpecGenerator.FixTypeName(moListIterator.Current.ObjectType);
					traversalSpec.Path = moListIterator.Current.PropertyPath;
					traversalSpec.Skip = new bool?(false);
					traversalSpec.SelectSet = DynamicPropertyFilterSpecGenerator.GenerateSelectionSet(null, moListIterator, --reverseCounter);
					list.Add(traversalSpec);
				}
				return list.ToArray();
			}
			if (list.Count != 0)
			{
				return list.ToArray();
			}
			return null;
		}
		private static void GeneratePropertySet(ref PropertyFilterSpec result, IEnumerable<DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition> managedObjectList)
		{
			foreach (DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition current in managedObjectList)
			{
				PropertySpec propertySpec = null;
				PropertySpec[] propSet = result.PropSet;
				for (int i = 0; i < propSet.Length; i++)
				{
					PropertySpec propertySpec2 = propSet[i];
					if (propertySpec2.Type == DynamicPropertyFilterSpecGenerator.FixTypeName(current.ObjectType))
					{
						propertySpec = propertySpec2;
						break;
					}
				}
				if (propertySpec != null)
				{
					if (propertySpec.All != true)
					{
						if (current.PropertyPath == "*")
						{
							propertySpec.All = new bool?(true);
							propertySpec.PathSet = null;
						}
						else
						{
							List<string> list = new List<string>(propertySpec.PathSet);
							if (!list.Contains(current.PropertyPath))
							{
								list.Add(current.PropertyPath);
							}
							propertySpec.PathSet = list.ToArray();
						}
					}
				}
				else
				{
					propertySpec = new PropertySpec();
					List<PropertySpec> list2 = new List<PropertySpec>(result.PropSet);
					propertySpec.Type = DynamicPropertyFilterSpecGenerator.FixTypeName(current.ObjectType);
					if (current.PropertyPath == "*")
					{
						propertySpec.All = new bool?(true);
					}
					else
					{
						propertySpec.All = new bool?(false);
						propertySpec.PathSet = new string[]
						{
							current.PropertyPath
						};
					}
					list2.Add(propertySpec);
					result.PropSet = list2.ToArray();
				}
			}
		}
		private static void SetPropertyTypesAndFixCasing(DynamicPropertyFilterSpecGenerator.PropertyDefinition[] propertyPathList, string startingType)
		{
			Type type = DynamicPropertyFilterSpecGenerator.GetType(startingType);
			int i = 0;
			while (i < propertyPathList.Length)
			{
				DynamicPropertyFilterSpecGenerator.PropertyDefinition propertyDefinition = propertyPathList[i];
				if (propertyDefinition.Name == "*")
				{
					break;
				}
				Dictionary<string, PropertyInfo> arg_3F_0 = ViReflectionCache.GetTypeProperties(type);
				PropertyInfo propertyInfo = null;
				arg_3F_0.TryGetValue(propertyDefinition.Name.ToLower(), out propertyInfo);
				if (propertyInfo == null)
				{
					throw new ArgumentException(string.Format(Resources.PropertyDoesNotExist, propertyDefinition.Name));
				}
				propertyDefinition.Name = VimClient.MakeCamelCase(propertyInfo.Name);
				if (propertyInfo.PropertyType == typeof(ManagedObjectReference) || propertyInfo.PropertyType == typeof(ManagedObjectReference[]))
				{
					type = DynamicPropertyFilterSpecGenerator.GetType(string.Format("{0}_LinkedView", type.Name));
					ViReflectionCache.GetTypeProperties(type).TryGetValue(propertyDefinition.Name.ToLower(), out propertyInfo);
					if (propertyDefinition.VimType != DynamicPropertyFilterSpecGenerator.VimType.ManagedObject)
					{
						propertyDefinition.VimType = DynamicPropertyFilterSpecGenerator.VimType.ManagedObject;
						goto IL_169;
					}
					if (!DynamicPropertyFilterSpecGenerator.GetType(DynamicPropertyFilterSpecGenerator.FixTypeName(propertyInfo.PropertyType.Name)).IsAssignableFrom(DynamicPropertyFilterSpecGenerator.GetType(propertyDefinition.ObjectType)))
					{
						throw new ArgumentException(string.Format(Resources.WrongPropertyType, propertyDefinition.Name, propertyInfo.PropertyType.Name));
					}
					type = DynamicPropertyFilterSpecGenerator.GetType(propertyDefinition.ObjectType);
				}
				else
				{
					if (propertyDefinition.VimType == DynamicPropertyFilterSpecGenerator.VimType.ManagedObject)
					{
						throw new ArgumentException(string.Format(Resources.SpecifiedDataObjectType, propertyDefinition.Name));
					}
					propertyDefinition.VimType = DynamicPropertyFilterSpecGenerator.VimType.DataObject;
					goto IL_169;
				}
				IL_18D:
				i++;
				continue;
				IL_169:
				type = DynamicPropertyFilterSpecGenerator.GetType(propertyInfo.PropertyType.Name);
				propertyDefinition.ObjectType = propertyInfo.PropertyType.Name;
				goto IL_18D;
			}
		}
		private static string FixTypeName(string typeName)
		{
			return typeName.Trim(new char[]
			{
				'[',
				']'
			});
		}
		private static Type GetType(string typeName)
		{
			return ViReflectionCache.GetTypeByRemoteTypeAndName(typeof(ManagedObjectReference), DynamicPropertyFilterSpecGenerator.FixTypeName(typeName));
		}
		private static List<DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition> GenerateManagedObjectList(IEnumerable<DynamicPropertyFilterSpecGenerator.PropertyDefinition> propertyList, string startingObjectType)
		{
			List<DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition> list = new List<DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition>();
			StringBuilder stringBuilder = new StringBuilder();
			DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition managedObjectDefinition = new DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition();
			managedObjectDefinition.ObjectType = startingObjectType;
			foreach (DynamicPropertyFilterSpecGenerator.PropertyDefinition current in propertyList)
			{
				if (current.VimType == DynamicPropertyFilterSpecGenerator.VimType.ManagedObject)
				{
					DynamicPropertyFilterSpecGenerator.AppendPropertyPath(ref stringBuilder, current.Name);
					managedObjectDefinition.PropertyPath = stringBuilder.ToString();
					list.Add(managedObjectDefinition);
					managedObjectDefinition = new DynamicPropertyFilterSpecGenerator.ManagedObjectDefinition();
					managedObjectDefinition.ObjectType = current.ObjectType;
					stringBuilder = new StringBuilder();
				}
				else
				{
					DynamicPropertyFilterSpecGenerator.AppendPropertyPath(ref stringBuilder, current.Name);
				}
			}
			if (stringBuilder.Length != 0)
			{
				managedObjectDefinition.PropertyPath = stringBuilder.ToString();
				list.Add(managedObjectDefinition);
			}
			return list;
		}
		private static void AppendPropertyPath(ref StringBuilder propertyPath, string token)
		{
			if (propertyPath.Length == 0)
			{
				propertyPath.Append(token);
				return;
			}
			propertyPath.Append(string.Format(".{0}", token));
		}
		private static DynamicPropertyFilterSpecGenerator.PropertyDefinition[] ParsePropertyPath(string propertyPath)
		{
			List<DynamicPropertyFilterSpecGenerator.PropertyDefinition> list = new List<DynamicPropertyFilterSpecGenerator.PropertyDefinition>();
			int num = propertyPath.IndexOf("*");
			if (num != -1 && num != propertyPath.Length - 1)
			{
				throw new ArgumentException(Resources.WrongWildcardPosition);
			}
			if (!DynamicPropertyFilterSpecGenerator.PROPERTY_PATH_VALIDATION_REGEX.IsMatch(propertyPath))
			{
				throw new ArgumentException(Resources.InvalidPropertyPath);
			}
			foreach (Match match in DynamicPropertyFilterSpecGenerator.PROPERTY_PATH_REGEX.Matches(propertyPath))
			{
				DynamicPropertyFilterSpecGenerator.PropertyDefinition propertyDefinition = new DynamicPropertyFilterSpecGenerator.PropertyDefinition();
				propertyDefinition.VimType = DynamicPropertyFilterSpecGenerator.VimType.Unknown;
				if (match.Groups["type"].Success)
				{
					propertyDefinition.ObjectType = match.Groups["type"].Captures[0].Value;
					propertyDefinition.VimType = DynamicPropertyFilterSpecGenerator.VimType.ManagedObject;
				}
				propertyDefinition.Name = match.Groups["name"].Captures[0].Value;
				list.Add(propertyDefinition);
			}
			return list.ToArray();
		}
	}
}

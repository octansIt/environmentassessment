using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
    public class ViewBase
    {
        private ManagedObjectReference _moRef;
        private IVimClient _client;

        public virtual ManagedObjectReference MoRef
        {
            get
            {
                return this._moRef;
            }
        }

        public virtual IVimClient Client
        {
            get
            {
                return this._client;
            }
        }

        protected virtual VimPortType VimServiceProxy
        {
            get
            {
                return (VimPortType)this._client.VimService;
            }
        }

        public ViewBase(IVimClient client, ManagedObjectReference moRef)
        {
            if (moRef == null)
                throw new ArgumentNullException("moRef");
            if (client == null)
                throw new ArgumentNullException("client");
            this._client = client;
            this._moRef = moRef;
        }

        public static PropertySpec[] GetPropertySpec(string typeName)
        {
            return new PropertySpec[1]
            {
        new PropertySpec()
        {
          All = new bool?(true),
          Type = typeName
        }
            };
        }

        public static PropertyFilterSpec GetPropertyFilterSpec(ManagedObjectReference moRef)
        {
            PropertySpec[] propertySpec = ViewBase.GetPropertySpec(moRef.Type);
            return new PropertyFilterSpec()
            {
                PropSet = propertySpec,
                ObjectSet = new ObjectSpec[1]
              {
          new ObjectSpec() { Obj = moRef }
              }
            };
        }

        public static Type GetViewType(string typeName)
        {
            return !string.IsNullOrEmpty(typeName) ? Type.GetType(typeof(ViewBase).Namespace + "." + typeName, false, true) : (Type)null;
        }

        public void UpdateViewData(params string[] properties)
        {
            PropertyCollector propertyCollector = new PropertyCollector(this._client, this._client.ServiceContent.PropertyCollector);
            PropertyFilterSpec resultPropertyFilterSpec;
            Dictionary<string, List<string>> currentAllowedPropertyPath;
            DynamicPropertyFilterSpecGenerator.Generate(this.MoRef, VimClient.MakePropertiesCamelCase(properties), out resultPropertyFilterSpec, out currentAllowedPropertyPath);
            PropertyFilterSpec[] specSet = new PropertyFilterSpec[1]
            {
        resultPropertyFilterSpec
            };
            ObjectContent[] objectContentArray = propertyCollector.RetrieveProperties(specSet);
            Dictionary<string, ObjectContent> objectContentList = new Dictionary<string, ObjectContent>();
            foreach (ObjectContent objectContent in objectContentArray)
                objectContentList.Add(objectContent.Obj.Value, objectContent);
            Dictionary<string, ViewBase> generatedManagedObjectList = new Dictionary<string, ViewBase>();
            if (properties != null)
            {
                List<string> stringList = new List<string>((IEnumerable<string>)properties);
            }
            ViewBase.SetViewData(this, (string)null, currentAllowedPropertyPath, objectContentList, generatedManagedObjectList);
        }

        public void UpdateViewData()
        {
            this.UpdateViewData((string[])null);
        }

        public void SetViewData(ObjectContent objectContent, string[] properties)
        {
            Dictionary<string, ObjectContent> objectContentList = new Dictionary<string, ObjectContent>();
            objectContentList.Add(objectContent.Obj.Value, objectContent);
            Dictionary<string, ViewBase> generatedManagedObjectList = new Dictionary<string, ViewBase>();
            PropertyFilterSpec resultPropertyFilterSpec;
            Dictionary<string, List<string>> currentAllowedPropertyPath;
            DynamicPropertyFilterSpecGenerator.Generate(objectContent.Obj, properties, out resultPropertyFilterSpec, out currentAllowedPropertyPath);
            ViewBase.SetViewData(this, (string)null, currentAllowedPropertyPath, objectContentList, generatedManagedObjectList);
        }

        internal static void SetViewData(ViewBase currentObject, string currentPropertyPath, Dictionary<string, List<string>> allowedPropertyPath, Dictionary<string, ObjectContent> objectContentList, Dictionary<string, ViewBase> generatedManagedObjectList)
        {
            if (currentPropertyPath == null)
                currentPropertyPath = string.Empty;
            if (!objectContentList.ContainsKey(currentObject.MoRef.Value))
                return;
            if (!generatedManagedObjectList.ContainsKey(currentObject.MoRef.Value))
                generatedManagedObjectList.Add(currentObject.MoRef.Value, currentObject);
            ObjectContent objectContent = objectContentList[currentObject.MoRef.Value];
            if (allowedPropertyPath != null)
                ViewBase.ClearViewData(currentObject, currentPropertyPath, new List<string>((IEnumerable<string>)allowedPropertyPath.Keys));
            else
                ViewBase.ClearViewData(currentObject, currentPropertyPath, (List<string>)null);
            if (objectContent.PropSet != null)
            {
                foreach (DynamicProperty prop in objectContent.PropSet)
                {
                    bool flag1 = false;
                    string key1 = string.Empty;
                    if (allowedPropertyPath != null)
                    {
                        key1 = string.Format("{0}{1}{2}", (object)currentPropertyPath, currentPropertyPath != "" ? (object)"." : (object)"", (object)prop.Name.ToLower());
                        string str = string.Format("{0}{1}{2}", (object)currentPropertyPath, currentPropertyPath != "" ? (object)"." : (object)"", (object)"*");
                        bool flag2 = false;
                        bool flag3 = false;
                        foreach (string key2 in allowedPropertyPath.Keys)
                        {
                            if (key2.StartsWith(key1))
                                flag2 = true;
                            if (key2.Equals(str) && ViReflectionCache.GetTypeProperties(currentObject.GetType()).ContainsKey(prop.Name.ToLower()))
                            {
                                flag3 = true;
                                break;
                            }
                            if (key2.Equals(key1))
                                flag3 = true;
                            if (flag2 & flag3)
                                break;
                        }
                        if (!flag3 & flag2)
                            flag1 = true;
                        if (!flag3 && !flag2)
                            continue;
                    }
                    string[] strArray = prop.Name.Split('.');
                    Type type = currentObject.GetType();
                    object currentObject1 = (object)currentObject;
                    for (int index = 0; index < strArray.Length - 1; ++index)
                    {
                        string name = "_" + strArray[index];
                        FieldInfo field = type.GetTypeInfo().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
                        object obj = field.GetValue(currentObject1);
                        type = field.FieldType;
                        if (obj == null)
                        {
                            obj = type.GetConstructor(Type.EmptyTypes).Invoke((object[])null);
                            field.SetValue(currentObject1, obj);
                        }
                        currentObject1 = obj;
                    }
                    FieldInfo field1 = type.GetField("_" + strArray[strArray.Length - 1], BindingFlags.Instance | BindingFlags.NonPublic);
                    if (!flag1)
                    {
                        foreach (FieldInfo fieldInfo in ViewBase.GetAllFieldsWithName("_" + strArray[strArray.Length - 1], type))
                            fieldInfo.SetValue(currentObject1, prop.Val);
                    }
                    ManagedObjectReference[] moList = (ManagedObjectReference[])null;
                    if (field1.FieldType == typeof(ManagedObjectReference))
                        moList = new ManagedObjectReference[1]
                        {
              (ManagedObjectReference) prop.Val
                        };
                    else if (field1.FieldType == typeof(ManagedObjectReference[]))
                    {
                        List<string> stringList = new List<string>();
                        if (allowedPropertyPath != null)
                        {
                            if (allowedPropertyPath.ContainsKey(key1) && allowedPropertyPath[key1] != null)
                                stringList.AddRange((IEnumerable<string>)allowedPropertyPath[key1]);
                            if (allowedPropertyPath.ContainsKey(key1 + "->") && allowedPropertyPath[key1 + "->"] != null)
                                stringList.AddRange((IEnumerable<string>)allowedPropertyPath[key1 + "->"]);
                        }
                        List<ManagedObjectReference> managedObjectReferenceList = new List<ManagedObjectReference>();
                        foreach (ManagedObjectReference managedObjectReference in (ManagedObjectReference[])prop.Val)
                        {
                            if (stringList.Count == 0 || stringList.Contains(managedObjectReference.Type))
                            {
                                managedObjectReferenceList.Add(managedObjectReference);
                            }
                            else
                            {
                                foreach (string typeName in stringList)
                                {
                                    if (ViReflectionCache.GetTypeByRemoteTypeAndName(typeof(ManagedObjectReference), typeName).IsAssignableFrom(ViReflectionCache.GetTypeByRemoteTypeAndName(typeof(ManagedObjectReference), managedObjectReference.Type)))
                                    {
                                        managedObjectReferenceList.Add(managedObjectReference);
                                        break;
                                    }
                                }
                            }
                        }
                        moList = managedObjectReferenceList.ToArray();
                    }
                    if (moList != null)
                    {
                        string str = string.Format("{0}{1}{2}", (object)currentPropertyPath, currentPropertyPath != "" ? (object)"." : (object)"", (object)prop.Name.ToLower());
                        if (ViewBase.IsNonTerminalPath(allowedPropertyPath, str))
                            ViewBase.SetExtView(currentObject1, field1.Name, currentObject._client, moList, objectContentList, generatedManagedObjectList, str, allowedPropertyPath);
                    }
                }
            }
            else if (objectContent.MissingSet != null && objectContent.MissingSet.Length != 0)
            {
                MethodFault fault = objectContent.MissingSet[0].Fault.Fault;
                throw new VimException(objectContent.MissingSet[0].Fault.LocalizedMessage, fault);
            }
        }

        private static IEnumerable<FieldInfo> GetAllFieldsWithName(string name, Type objectType)
        {
            FieldInfo[] fieldInfoArray = objectType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            for (int index = 0; index < fieldInfoArray.Length; ++index)
            {
                FieldInfo fieldInfo = fieldInfoArray[index];
                if (fieldInfo.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                    yield return fieldInfo;
            }
            fieldInfoArray = (FieldInfo[])null;
        }

        private static bool IsNonTerminalPath(Dictionary<string, List<string>> allowedPropertyPaths, string tempPropertyPath)
        {
            bool flag = false;
            if (allowedPropertyPaths != null)
            {
                foreach (string key in allowedPropertyPaths.Keys)
                {
                    if (key.StartsWith(tempPropertyPath) && key != tempPropertyPath)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        private static void SetExtView(object currentObject, string moPropertyName, IVimClient client, ManagedObjectReference[] moList, Dictionary<string, ObjectContent> objectContentList, Dictionary<string, ViewBase> generatedManagedObjectList, string currentPropertyPath, Dictionary<string, List<string>> allowedPropertyPath)
        {
            ArrayList arrayList = new ArrayList();
            bool flag = false;
            if (moList.Length == 0)
                flag = true;
            FieldInfo field1 = currentObject.GetType().GetTypeInfo().GetField("_linkedView", BindingFlags.Instance | BindingFlags.NonPublic);
            Dictionary<string, PropertyInfo> typeProperties = ViReflectionCache.GetTypeProperties(currentObject.GetType());
            PropertyInfo propertyInfo = (PropertyInfo)null;
            string lower = "LinkedView".ToLower();
            typeProperties.TryGetValue(lower, out propertyInfo);
            FieldInfo field2 = propertyInfo.PropertyType.GetField(moPropertyName, BindingFlags.Instance | BindingFlags.NonPublic);
            bool isArray = field2.FieldType.IsArray;
            Type type = isArray ? field2.FieldType.GetElementType() : field2.FieldType;
            foreach (ManagedObjectReference mo in moList)
            {
                if (objectContentList.ContainsKey(mo.Value) || generatedManagedObjectList.ContainsKey(mo.Value))
                {
                    object obj;
                    if (generatedManagedObjectList.ContainsKey(mo.Value))
                        obj = (object)generatedManagedObjectList[mo.Value];
                    else
                        obj = ViewBase.GetViewType(mo.Type).GetConstructor(new Type[2]
                        {
              typeof (IVimClient),
              typeof (ManagedObjectReference)
                        }).Invoke(new object[2]
                        {
              (object) client,
              (object) mo
                        });
                    ViewBase.SetViewData((ViewBase)obj, currentPropertyPath, allowedPropertyPath, objectContentList, generatedManagedObjectList);
                    arrayList.Add(obj);
                }
            }
            if (!flag && arrayList.Count <= 0)
                return;
            object obj1 = propertyInfo.GetValue(currentObject, (object[])null) ?? ViReflectionCache.GetTypeDefaultConstructor(propertyInfo.PropertyType).Invoke((object[])null);
            field1.SetValue(currentObject, obj1);
            if (!isArray)
                field2.SetValue(obj1, arrayList[0]);
            else
                field2.SetValue(obj1, (object)arrayList.ToArray(type));
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
                foreach (string property in properties)
                {
                    string[] strArray = property.Split('.');
                    Type type = currentObject.GetType();
                    object obj1 = (object)currentObject;
                    bool flag = false;
                    for (int index = 0; index < strArray.Length - 1; ++index)
                    {
                        string name = "_" + strArray[index];
                        FieldInfo field = type.GetTypeInfo().GetField(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
                        if (field != (FieldInfo)null)
                        {
                            if (field.FieldType == typeof(ManagedObjectReference) && index <= strArray.Length - 2)
                                ViewBase.ClearExtView(obj1);
                            object obj2 = field.GetValue(obj1);
                            type = field.FieldType;
                            if (obj2 == null)
                            {
                                flag = true;
                                break;
                            }
                            obj1 = obj2;
                        }
                    }
                    if (!flag)
                    {
                        FieldInfo field = type.GetField("_" + strArray[strArray.Length - 1], BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
                        if (field != (FieldInfo)null)
                            ViewBase.ClearField(obj1, field);
                    }
                }
            }
            else
            {
                ManagedObjectReference moRef = currentObject._moRef;
                IVimClient client = currentObject._client;
                foreach (FieldInfo field in currentObject.GetType().GetTypeInfo().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
                    ViewBase.ClearField((object)currentObject, field);
                currentObject._moRef = moRef;
                currentObject._client = client;
            }
        }

        private static void ClearExtView(object obj)
        {
            PropertyInfo property = obj.GetType().GetTypeInfo().GetProperty("LinkedView", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            FieldInfo field = obj.GetType().GetTypeInfo().GetField("_linkedView", BindingFlags.Instance | BindingFlags.NonPublic);
            if (property.GetValue(obj, (object[])null) != null)
                return;
            object obj1 = ViReflectionCache.GetTypeDefaultConstructor(property.PropertyType).Invoke((object[])null);
            field.SetValue(obj, obj1);
        }

        private static List<string> GetCurrentProperties(string currentPath, List<string> properties)
        {
            List<string> stringList = new List<string>();
            if (properties != null)
            {
                foreach (string property in properties)
                {
                    if (currentPath != property && property.StartsWith(currentPath) && !property.EndsWith("->"))
                        stringList.Add(property.Substring(currentPath.Length));
                }
            }
            return stringList;
        }

        private static void ClearField(object obj, FieldInfo field)
        {
            if (field.GetType().GetTypeInfo().IsValueType)
                field.SetValue(obj, Activator.CreateInstance(field.GetType()));
            else
                field.SetValue(obj, (object)null);
        }
    }
}

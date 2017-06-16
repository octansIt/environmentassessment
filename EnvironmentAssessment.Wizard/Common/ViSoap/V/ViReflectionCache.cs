using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
namespace EnvironmentAssessment.Common.VISoap
{
	internal sealed class ViReflectionCache
	{
		private class ReflectionCacheItem
		{
			public readonly Type Type;
			public ConstructorInfo DefaultConstructor;
			public Dictionary<string, PropertyInfo> Properties;
			public ReflectionCacheItem(Type type)
			{
				this.Type = type;
			}
		}
		private static readonly Dictionary<string, ViReflectionCache.ReflectionCacheItem> _cache;
		private static object _lock;
		static ViReflectionCache()
		{
			ViReflectionCache._lock = new object();
			ViReflectionCache._cache = new Dictionary<string, ViReflectionCache.ReflectionCacheItem>();
		}
		public static Type GetTypeByRemoteTypeAndName(Type remoteType, string typeName)
		{
			Type type = null;
			string text = remoteType.Namespace + "." + typeName;
			ViReflectionCache.ReflectionCacheItem reflectionCacheItem = null;
			object @lock;
			Monitor.Enter(@lock = ViReflectionCache._lock);
			try
			{
				if (!ViReflectionCache._cache.TryGetValue(text, out reflectionCacheItem))
				{
					type = remoteType.Assembly.GetType(text);
					ViReflectionCache._cache[text] = new ViReflectionCache.ReflectionCacheItem(type);
				}
				else
				{
					type = reflectionCacheItem.Type;
				}
			}
			finally
			{
				Monitor.Exit(@lock);
			}
			return type;
		}
		public static ConstructorInfo GetTypeDefaultConstructor(Type type)
		{
			ViReflectionCache.ReflectionCacheItem reflectionCacheItemByType = ViReflectionCache.GetReflectionCacheItemByType(type);
			ConstructorInfo constructorInfo = reflectionCacheItemByType.DefaultConstructor;
			if (constructorInfo == null)
			{
				constructorInfo = type.GetConstructor(Type.EmptyTypes);
				reflectionCacheItemByType.DefaultConstructor = constructorInfo;
			}
			return constructorInfo;
		}
		public static Dictionary<string, PropertyInfo> GetTypeProperties(Type type)
		{
			ViReflectionCache.ReflectionCacheItem reflectionCacheItemByType = ViReflectionCache.GetReflectionCacheItemByType(type);
			Dictionary<string, PropertyInfo> dictionary = reflectionCacheItemByType.Properties;
			if (dictionary == null)
			{
				PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
				dictionary = new Dictionary<string, PropertyInfo>(properties.Length);
				PropertyInfo[] array = properties;
				for (int i = 0; i < array.Length; i++)
				{
					PropertyInfo propertyInfo = array[i];
					string key = propertyInfo.Name.ToLower();
					if (!dictionary.ContainsKey(key))
					{
						dictionary.Add(key, propertyInfo);
					}
					else
					{
						if (dictionary[key].PropertyType.IsAssignableFrom(propertyInfo.PropertyType))
						{
							dictionary[key] = propertyInfo;
						}
					}
				}
				reflectionCacheItemByType.Properties = dictionary;
			}
			return dictionary;
		}
		public static PropertyInfo GetTypePropertyByName(Type type, string propName)
		{
			PropertyInfo result;
			ViReflectionCache.GetTypeProperties(type).TryGetValue(propName, out result);
			return result;
		}
		private static ViReflectionCache.ReflectionCacheItem GetReflectionCacheItemByType(Type type)
		{
			ViReflectionCache.ReflectionCacheItem reflectionCacheItem = null;
			string fullName = type.FullName;
			object @lock;
			Monitor.Enter(@lock = ViReflectionCache._lock);
			try
			{
				if (!ViReflectionCache._cache.TryGetValue(fullName, out reflectionCacheItem))
				{
					reflectionCacheItem = new ViReflectionCache.ReflectionCacheItem(type);
					ViReflectionCache._cache[fullName] = reflectionCacheItem;
				}
			}
			finally
			{
				Monitor.Exit(@lock);
			}
			return reflectionCacheItem;
		}
	}
}

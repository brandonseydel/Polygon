using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace Polygon.Helpers
{
	public static class Helpers
	{

		private static ConcurrentDictionary<Type, PropertyInfo[]> _propertyDictionary = new ConcurrentDictionary<Type, PropertyInfo[]>();
		public static string ToQueryString<T>(this T obj) where T : class
		{
			if (obj == null) return "";

			var type = typeof(T);

			if (!_propertyDictionary.TryGetValue(type, out var properties))
			{
				properties = type.GetProperties();
				_propertyDictionary.TryAdd(type, properties);
			}

			return "?" + string.Join("&", properties.Select(x => $"{x.Name.Replace(x.Name[0], char.ToLower(x.Name[0]))}={(x.PropertyType == typeof(bool) || x.PropertyType == typeof(bool?) ? x.GetValue(obj)?.ToString().ToLower() : x.GetValue(obj))}"));
		}

		public static DateTime? GetUTCTimeFromUnixTimestamp(this long? unixTimetsamp) => unixTimetsamp.HasValue ? System.DateTime.UnixEpoch.AddMilliseconds(unixTimetsamp.Value) : null as DateTime?;
	}
}

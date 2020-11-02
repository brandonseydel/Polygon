using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class CryptoSnapshotBookItem
	{
		/// <summary>
		/// Price of this book level
		/// </summary>
		/// <value>Price of this book level</value>

		[JsonPropertyName("p")]
		public double? P { get; set; }

		/// <summary>
		/// Exchange to Size of this price level
		/// </summary>
		/// <value>Exchange to Size of this price level</value>

		[JsonPropertyName("x")]
		public object X { get; set; }
	}
}

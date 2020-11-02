using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class CryptoTick
	{
		/// <summary>
		/// Trade Price
		/// </summary>
		/// <value>Trade Price</value>

		[JsonPropertyName("price")]
		public double? Price { get; set; }

		/// <summary>
		/// Size of the trade
		/// </summary>
		/// <value>Size of the trade</value>

		[JsonPropertyName("size")]
		public double? Size { get; set; }

		/// <summary>
		/// Exchange the trade occurred on
		/// </summary>
		/// <value>Exchange the trade occurred on</value>

		[JsonPropertyName("exchange")]
		public int? Exchange { get; set; }

		/// <summary>
		/// Conditions of this trade
		/// </summary>
		/// <value>Conditions of this trade</value>

		[JsonPropertyName("conditions")]
		public List<int?> Conditions { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; set; }

	}
}

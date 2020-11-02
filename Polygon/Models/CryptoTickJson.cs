using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class CryptoTickJson
	{
		/// <summary>
		/// Trade Price
		/// </summary>
		/// <value>Trade Price</value>

		[JsonPropertyName("p")]
		public double? P { get; set; }

		/// <summary>
		/// Size of the trade
		/// </summary>
		/// <value>Size of the trade</value>

		[JsonPropertyName("s")]
		public double? S { get; set; }

		/// <summary>
		/// Exchange the trade occurred on
		/// </summary>
		/// <value>Exchange the trade occurred on</value>

		[JsonPropertyName("x")]
		public int? X { get; set; }

		/// <summary>
		/// Conditions of this trade
		/// </summary>
		/// <value>Conditions of this trade</value>

		[JsonPropertyName("c")]
		public List<int?> C { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("t")]
		public int? T { get; set; }
	}
}

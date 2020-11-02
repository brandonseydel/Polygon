using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Forex
	{
		/// <summary>
		/// Ask price
		/// </summary>
		/// <value>Ask price</value>

		[JsonPropertyName("a")]
		public double? A { get; set; }

		/// <summary>
		/// Bid price
		/// </summary>
		/// <value>Bid price</value>

		[JsonPropertyName("b")]
		public double? B { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("t")]
		public int? T { get; set; }
	}
}

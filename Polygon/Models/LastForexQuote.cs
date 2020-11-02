using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class LastForexQuote
	{
		/// <summary>
		/// Ask Price
		/// </summary>
		/// <value>Ask Price</value>

		[JsonPropertyName("ask")]
		public double? Ask { get; set; }

		/// <summary>
		/// Bid Price
		/// </summary>
		/// <value>Bid Price</value>

		[JsonPropertyName("bid")]
		public double? Bid { get; set; }

		/// <summary>
		/// Exchange this trade happened on
		/// </summary>
		/// <value>Exchange this trade happened on</value>

		[JsonPropertyName("exchange")]
		public int? Exchange { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; set; }
	}
}

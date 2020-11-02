using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class StocksSnapshotQuote
	{
		/// <summary>
		/// Bid Price
		/// </summary>
		/// <value>Bid Price</value>

		[JsonPropertyName("p")]
		public double? BidPrice { get; set; }

		/// <summary>
		/// Bid size in lots
		/// </summary>
		/// <value>Bid size in lots</value>

		[JsonPropertyName("s")]
		public int? BidSize { get; set; }

		/// <summary>
		/// Ask Price
		/// </summary>
		/// <value>Ask Price</value>

		[JsonPropertyName("P")]
		public double? AskPrice { get; set; }

		/// <summary>
		/// Ask size in lots
		/// </summary>
		/// <value>Ask size in lots</value>

		[JsonPropertyName("S")]
		public int? AskSize { get; set; }

		/// <summary>
		/// Last Updated timestamp ( Nanosecond Timestamp )
		/// </summary>
		/// <value>Last Updated timestamp ( Nanosecond Timestamp )</value>

		[JsonPropertyName("t")]
		public long? Timestamp { get; set; }

	}
}

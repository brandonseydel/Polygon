using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Quote
	{
		/// <summary>
		/// Condition of this quote
		/// </summary>
		/// <value>Condition of this quote</value>

		[JsonPropertyName("c")]
		public int? Condition { get; set; }

		/// <summary>
		/// Bid Exchange
		/// </summary>
		/// <value>Bid Exchange</value>

		[JsonPropertyName("bE")]
		public string BidExchange { get; set; }

		/// <summary>
		/// Ask Exchange
		/// </summary>
		/// <value>Ask Exchange</value>

		[JsonPropertyName("aE")]
		public string AskExchange { get; set; }

		/// <summary>
		/// Ask Price
		/// </summary>
		/// <value>Ask Price</value>

		[JsonPropertyName("aP")]
		public double? AskPprice { get; set; }

		/// <summary>
		/// Bid Price
		/// </summary>
		/// <value>Bid Price</value>

		[JsonPropertyName("bP")]
		public double? BidPrice { get; set; }

		/// <summary>
		/// Bid Size
		/// </summary>
		/// <value>Bid Size</value>

		[JsonPropertyName("bS")]
		public int? BidSize { get; set; }

		/// <summary>
		/// Ask Size
		/// </summary>
		/// <value>Ask Size</value>

		[JsonPropertyName("aS")]
		public int? AskSize { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("t")]
		public long? Timestamp { get; set; }
	}
}

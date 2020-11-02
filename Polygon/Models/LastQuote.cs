using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class LastQuote
	{
		/// <summary>
		/// Ask Price
		/// </summary>
		/// <value>Ask Price</value>

		[JsonPropertyName("askprice")]
		public double? AskPrice { get; set; }

		/// <summary>
		/// Ask Size
		/// </summary>
		/// <value>Ask Size</value>

		[JsonPropertyName("asksize")]
		public int? AskSize { get; set; }

		/// <summary>
		/// Exchange the ask happened on
		/// </summary>
		/// <value>Exchange the ask happened on</value>

		[JsonPropertyName("askexchange")]
		public int? AskExchange { get; set; }

		/// <summary>
		/// Bid Price
		/// </summary>
		/// <value>Bid Price</value>

		[JsonPropertyName("bidprice")]
		public double? Bidprice { get; set; }

		/// <summary>
		/// Bid Size
		/// </summary>
		/// <value>Bid Size</value>

		[JsonPropertyName("bidsize")]
		public int? Bidsize { get; set; }

		/// <summary>
		/// Exchange the bid happened on
		/// </summary>
		/// <value>Exchange the bid happened on</value>

		[JsonPropertyName("bidexchange")]
		public int? Bidexchange { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; set; }

	}
}

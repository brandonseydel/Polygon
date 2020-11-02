using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{

	public class StocksOpenClose
	{
		/// <summary>
		/// Status of this response
		/// </summary>
		/// <value>Status of this response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Requested date
		/// </summary>
		/// <value>Requested date</value>

		[JsonPropertyName("from")]
		public DateTime? From { get; set; }

		/// <summary>
		/// Ticker symbol requested
		/// </summary>
		/// <value>Ticker symbol requested</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Official open price
		/// </summary>
		/// <value>Official open price</value>

		[JsonPropertyName("open")]
		public double? Open { get; set; }

		/// <summary>
		/// Official high price
		/// </summary>
		/// <value>Official high price</value>

		[JsonPropertyName("high")]
		public double? High { get; set; }

		/// <summary>
		/// Official low price
		/// </summary>
		/// <value>Official low price</value>

		[JsonPropertyName("low")]
		public double? Low { get; set; }

		/// <summary>
		/// Official close price
		/// </summary>
		/// <value>Official close price</value>

		[JsonPropertyName("close")]
		public double? Close { get; set; }

		/// <summary>
		/// Volume of shares
		/// </summary>
		/// <value>Volume of shares</value>

		[JsonPropertyName("volume")]
		public int? Volume { get; set; }

		/// <summary>
		/// Open price in pre-market trading
		/// </summary>
		/// <value>Open price in pre-market trading</value>

		[JsonPropertyName("preMarket")]
		public double? PreMarket { get; set; }

		/// <summary>
		/// Close price after hours trading
		/// </summary>
		/// <value>Close price after hours trading</value>

		[JsonPropertyName("afterHours")]
		public double? AfterHours { get; set; }


	}
}

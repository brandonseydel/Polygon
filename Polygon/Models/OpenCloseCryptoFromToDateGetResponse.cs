using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class OpenCloseCryptoFromToDateGetResponse
	{
		/// <summary>
		/// Symbol Pair that was evaluated from the request
		/// </summary>
		/// <value>Symbol Pair that was evaluated from the request</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// If the timestamps are in UTC timezone
		/// </summary>
		/// <value>If the timestamps are in UTC timezone</value>

		[JsonPropertyName("isUTC")]
		public bool? IsUTC { get; set; }

		/// <summary>
		/// Gets or Sets Day
		/// </summary>

		[JsonPropertyName("day")]
		public DateTime? Day { get; set; }

		/// <summary>
		/// Opening trade price
		/// </summary>
		/// <value>Opening trade price</value>

		[JsonPropertyName("open")]
		public double? Open { get; set; }

		/// <summary>
		/// Closing trade price
		/// </summary>
		/// <value>Closing trade price</value>

		[JsonPropertyName("close")]
		public double? Close { get; set; }

		/// <summary>
		/// Gets or Sets OpenTrades
		/// </summary>

		[JsonPropertyName("openTrades")]
		public List<CryptoTickJson> OpenTrades { get; set; }

		/// <summary>
		/// Gets or Sets ClosingTrades
		/// </summary>

		[JsonPropertyName("closingTrades")]
		public List<CryptoTickJson> ClosingTrades { get; set; }
	}
}

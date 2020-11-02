using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class CryptoSnapshotTickerBook
	{
		/// <summary>
		/// Ticker of the object
		/// </summary>
		/// <value>Ticker of the object</value>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Bids
		/// </summary>
		/// <value>Bids</value>

		[JsonPropertyName("bids")]
		public List<CryptoSnapshotBookItem> Bids { get; set; }

		/// <summary>
		/// Asks
		/// </summary>
		/// <value>Asks</value>

		[JsonPropertyName("asks")]
		public List<CryptoSnapshotBookItem> Asks { get; set; }

		/// <summary>
		/// Combined total number of bids in the book
		/// </summary>
		/// <value>Combined total number of bids in the book</value>

		[JsonPropertyName("bidCount")]
		public double? BidCount { get; set; }

		/// <summary>
		/// Combined total number of asks in the book
		/// </summary>
		/// <value>Combined total number of asks in the book</value>

		[JsonPropertyName("askCount")]
		public double? AskCount { get; set; }

		/// <summary>
		/// Difference between the best bid and the best ask price accross exchanges
		/// </summary>
		/// <value>Difference between the best bid and the best ask price accross exchanges</value>

		[JsonPropertyName("spread")]
		public double? Spread { get; set; }

		/// <summary>
		/// Last Updated timestamp
		/// </summary>
		/// <value>Last Updated timestamp</value>

		[JsonPropertyName("updated")]
		public long? Updated { get; set; }
	}
}

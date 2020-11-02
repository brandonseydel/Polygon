using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class SnapshotLocaleGlobalMarketsCryptoTickersTickerGetResponse
	{
		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets Ticker
		/// </summary>

		[JsonPropertyName("ticker")]
		public CryptoSnapshotTicker Ticker { get; set; }
	}
}

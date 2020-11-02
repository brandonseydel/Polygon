using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class SnapshotLocaleGlobalMarketsCryptoTickersTickerBookGetResponse
	{
		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets Data
		/// </summary>

		[JsonPropertyName("data")]
		public CryptoSnapshotTickerBook Data { get; set; }

	}
}

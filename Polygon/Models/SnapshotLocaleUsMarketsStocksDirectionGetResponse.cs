using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class SnapshotLocaleUsMarketsStocksDirectionGetResponse
	{
		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>
		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets Tickers
		/// </summary>
		[JsonPropertyName("tickers")]
		public List<StocksSnapshotTicker> Tickers { get; set; }

	}
}

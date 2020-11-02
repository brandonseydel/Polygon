using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Polygon.Models
{
	public class ReferenceTickersGetResponse
	{
		public ReferenceTickersGetResponse()
		{
			Tickers = new HashSet<TickerData>();
		}

		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Symbol that was evaluated from the request
		/// </summary>
		/// <value>Symbol that was evaluated from the request</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Gets or Sets Last
		/// </summary>

		[JsonPropertyName("tickers")]
		public IEnumerable<TickerData> Tickers { get; set; }
	}
}

using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class TicksStocksTradesTickerDateGetResponse
	{
		/// <summary>
		/// Total number of results in this response
		/// </summary>
		/// <value>Total number of results in this response</value>

		[JsonPropertyName("results_count")]
		public int? ResultsCount { get; set; }

		/// <summary>
		/// Milliseconds of latency for the query results from DB
		/// </summary>
		/// <value>Milliseconds of latency for the query results from DB</value>

		[JsonPropertyName("db_latency")]
		public int? DbLatency { get; set; }

		/// <summary>
		/// If this query was executed successfully
		/// </summary>
		/// <value>If this query was executed successfully</value>

		[JsonPropertyName("success")]
		public bool? Success { get; set; }

		/// <summary>
		/// Ticker symbol that was evaluated from the request
		/// </summary>
		/// <value>Ticker symbol that was evaluated from the request</value>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Gets or Sets Results
		/// </summary>

		[JsonPropertyName("results")]
		public List<StocksV2Trade> Results { get; set; }
	}
}

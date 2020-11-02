using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class AggResponse
	{
		/// <summary>
		/// Ticker symbol requested
		/// </summary>
		/// <value>Ticker symbol requested</value>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Status of the response
		/// </summary>
		/// <value>Status of the response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// If this response was adjusted for splits
		/// </summary>
		/// <value>If this response was adjusted for splits</value>

		[JsonPropertyName("adjusted")]
		public bool? Adjusted { get; set; }

		/// <summary>
		/// Number of aggregate (min or day) used to generate the response
		/// </summary>
		/// <value>Number of aggregate (min or day) used to generate the response</value>

		[JsonPropertyName("queryCount")]
		public int? QueryCount { get; set; }

		/// <summary>
		/// Total number of results generated
		/// </summary>
		/// <value>Total number of results generated</value>

		[JsonPropertyName("resultsCount")]
		public int? ResultsCount { get; set; }

		/// <summary>
		/// Gets or Sets Results
		/// </summary>

		[JsonPropertyName("results")]
		public List<Aggv2> Results { get; set; }
	}
}

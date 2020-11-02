using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class ReferenceDividendsSymbolGetResponse
	{
		/// <summary>
		/// Gets or Sets Status
		/// </summary>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets Count
		/// </summary>

		[JsonPropertyName("count")]
		public int? Count { get; set; }

		/// <summary>
		/// Gets or Sets Results
		/// </summary>

		[JsonPropertyName("results")]
		public List<Dividend> Results { get; set; }


	}
}

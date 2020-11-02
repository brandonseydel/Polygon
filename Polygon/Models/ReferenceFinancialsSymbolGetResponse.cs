using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{



	public class ReferenceFinancialsSymbolGetResponse
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
		public List<Financials> Results { get; set; }

	}
}

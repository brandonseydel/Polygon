using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Exchange
	{
		/// <summary>
		/// ID of the exchange
		/// </summary>
		/// <value>ID of the exchange</value>

		[JsonPropertyName("id")]
		public decimal? Id { get; set; }

		/// <summary>
		/// The type of exchange this is.<br/> - TRF = Trade Reporting Facility<br/> - exchange = Reporting exchange on the tape 
		/// </summary>
		/// <value>The type of exchange this is.<br/> - TRF = Trade Reporting Facility<br/> - exchange = Reporting exchange on the tape </value>

		[JsonPropertyName("type")]
		public string Type { get; set; }

		/// <summary>
		/// Market data type this exchange contains
		/// </summary>
		/// <value>Market data type this exchange contains</value>

		[JsonPropertyName("market")]
		public string Market { get; set; }

		/// <summary>
		/// Market Identification Code
		/// </summary>
		/// <value>Market Identification Code</value>

		[JsonPropertyName("mic")]
		public string Mic { get; set; }

		/// <summary>
		/// Name of the exchange
		/// </summary>
		/// <value>Name of the exchange</value>

		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Tape id of the exchange
		/// </summary>
		/// <value>Tape id of the exchange</value>

		[JsonPropertyName("tape")]
		public string Tape { get; set; }
	}
}

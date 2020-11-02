using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class TickerCodes
	{
		/// <summary>
		/// CIK number for this ticker
		/// </summary>
		/// <value>CIK number for this ticker</value>

		[JsonPropertyName("cik")]
		public string Cik { get; set; }

		/// <summary>
		/// OpenFIGI number for this ticker
		/// </summary>
		/// <value>OpenFIGI number for this ticker</value>

		[JsonPropertyName("figi")]
		public string Figi { get; set; }

		/// <summary>
		/// Composite OpenFIGI number for this ticker
		/// </summary>
		/// <value>Composite OpenFIGI number for this ticker</value>

		[JsonPropertyName("cfigi")]
		public string Cfigi { get; set; }

		/// <summary>
		/// Shared Class OpenFIGI number for this ticker
		/// </summary>
		/// <value>Shared Class OpenFIGI number for this ticker</value>

		[JsonPropertyName("scfigi")]
		public string Scfigi { get; set; }

		/// <summary>
		/// Unique OpenFIGI ID number for this ticker
		/// </summary>
		/// <value>Unique OpenFIGI ID number for this ticker</value>

		[JsonPropertyName("figiuid")]
		public string Figiuid { get; set; }
	}
}

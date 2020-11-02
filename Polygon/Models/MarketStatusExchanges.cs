using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class MarketStatusExchanges
	{
		/// <summary>
		/// Status of the market as a whole
		/// </summary>
		/// <value>Status of the market as a whole</value>

		[JsonPropertyName("nyse")]
		public string Nyse { get; set; }

		/// <summary>
		/// Status of the market as a whole
		/// </summary>
		/// <value>Status of the market as a whole</value>

		[JsonPropertyName("nasdaq")]
		public string Nasdaq { get; set; }

		/// <summary>
		/// Status of the market as a whole
		/// </summary>
		/// <value>Status of the market as a whole</value>

		[JsonPropertyName("otc")]
		public string Otc { get; set; }
	}
}

using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class MarketStatusCurrencies
	{
		/// <summary>
		/// Status of the forex market
		/// </summary>
		/// <value>Status of the forex market</value>

		[JsonPropertyName("fx")]
		public string Fx { get; set; }

		/// <summary>
		/// Status of the crypto market
		/// </summary>
		/// <value>Status of the crypto market</value>

		[JsonPropertyName("crypto")]
		public string Crypto { get; set; }
	}
}

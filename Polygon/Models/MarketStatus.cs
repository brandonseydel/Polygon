using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class MarketStatus
	{
		/// <summary>
		/// Status of the market as a whole
		/// </summary>
		/// <value>Status of the market as a whole</value>

		[JsonPropertyName("market")]
		public string Market { get; set; }

		public bool IsOpen { get => Market == "open"; }

		/// <summary>
		/// Current time of the server
		/// </summary>
		/// <value>Current time of the server</value>

		[JsonPropertyName("serverTime")]
		public DateTime? ServerTime { get; set; }

		/// <summary>
		/// Gets or Sets Exchanges
		/// </summary>

		[JsonPropertyName("exchanges")]
		public MarketStatusExchanges Exchanges { get; set; }

		/// <summary>
		/// Gets or Sets Currencies
		/// </summary>

		[JsonPropertyName("currencies")]
		public MarketStatusCurrencies Currencies { get; set; }
	}
}

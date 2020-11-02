using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class CryptoExchange
	{
		/// <summary>
		/// ID of the exchange
		/// </summary>
		/// <value>ID of the exchange</value>

		[JsonPropertyName("id")]
		public int? Id { get; set; }

		/// <summary>
		/// Type of exchange feed
		/// </summary>
		/// <value>Type of exchange feed</value>

		[JsonPropertyName("type")]
		public string Type { get; set; }

		/// <summary>
		/// Market data type this exchange contains ( crypto only currently )
		/// </summary>
		/// <value>Market data type this exchange contains ( crypto only currently )</value>

		[JsonPropertyName("market")]
		public string Market { get; set; }

		/// <summary>
		/// Name of the exchange
		/// </summary>
		/// <value>Name of the exchange</value>

		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// URL of this exchange
		/// </summary>
		/// <value>URL of this exchange</value>

		[JsonPropertyName("url")]
		public string Url { get; set; }
	}
}

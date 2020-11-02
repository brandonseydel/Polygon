using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class LastCryptoFromToGetResponse
	{
		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Symbol Pair that was evaluated from the request
		/// </summary>
		/// <value>Symbol Pair that was evaluated from the request</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Gets or Sets Last
		/// </summary>

		[JsonPropertyName("last")]
		public CryptoTick Last { get; set; }

		/// <summary>
		/// Gets or Sets LastAverage
		/// </summary>

		[JsonPropertyName("lastAverage")]
		public InlineResponse20016LastAverage LastAverage { get; set; }
	}
}

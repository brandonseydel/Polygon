using System.Text.Json.Serialization;


namespace Polygon.Models
{

	public class ConversionFromToGetResponse
	{
		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// From currency symbol
		/// </summary>
		/// <value>From currency symbol</value>

		[JsonPropertyName("from")]
		public string From { get; set; }

		/// <summary>
		/// To currency symbol
		/// </summary>
		/// <value>To currency symbol</value>

		[JsonPropertyName("to")]
		public string To { get; set; }

		/// <summary>
		/// The amount we are to convert
		/// </summary>
		/// <value>The amount we are to convert</value>

		[JsonPropertyName("initialAmount")]
		public double? InitialAmount { get; set; }

		/// <summary>
		/// To currency symbol
		/// </summary>
		/// <value>To currency symbol</value>

		[JsonPropertyName("converted")]
		public double? Converted { get; set; }

		/// <summary>
		/// Gets or Sets LastTrade
		/// </summary>

		[JsonPropertyName("lastTrade")]
		public LastForexTrade LastTrade { get; set; }

		/// <summary>
		/// Symbol Pair that was evaluated from the request
		/// </summary>
		/// <value>Symbol Pair that was evaluated from the request</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }


	}
}

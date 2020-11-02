using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class LastForexTrade
	{
		/// <summary>
		/// Price of the trade
		/// </summary>
		/// <value>Price of the trade</value>

		[JsonPropertyName("price")]
		public double? Price { get; set; }

		/// <summary>
		/// Exchange this trade happened on
		/// </summary>
		/// <value>Exchange this trade happened on</value>

		[JsonPropertyName("exchange")]
		public int? Exchange { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; set; }
	}
}

using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class HistTrade
	{
		/// <summary>
		/// Condition 1 of this trade
		/// </summary>
		/// <value>Condition 1 of this trade</value>

		[JsonPropertyName("condition1")]
		public int? Condition1 { get; set; }

		/// <summary>
		/// Condition 2 of this trade
		/// </summary>
		/// <value>Condition 2 of this trade</value>

		[JsonPropertyName("condition2")]
		public int? Condition2 { get; set; }

		/// <summary>
		/// Condition 3 of this trade
		/// </summary>
		/// <value>Condition 3 of this trade</value>

		[JsonPropertyName("condition3")]
		public int? Condition3 { get; set; }

		/// <summary>
		/// Condition 4 of this trade
		/// </summary>
		/// <value>Condition 4 of this trade</value>

		[JsonPropertyName("condition4")]
		public int? Condition4 { get; set; }

		/// <summary>
		/// The exchange this trade happened on
		/// </summary>
		/// <value>The exchange this trade happened on</value>

		[JsonPropertyName("exchange")]
		public string Exchange { get; set; }

		/// <summary>
		/// Price of the trade
		/// </summary>
		/// <value>Price of the trade</value>

		[JsonPropertyName("price")]
		public double? Price { get; set; }

		/// <summary>
		/// Size of the trade
		/// </summary>
		/// <value>Size of the trade</value>

		[JsonPropertyName("size")]
		public int? Size { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("timestamp")]
		public string Timestamp { get; set; }

	}
}

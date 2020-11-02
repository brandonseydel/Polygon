using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class LastTrade
	{
		/// <summary>
		/// Price of the trade
		/// </summary>
		/// <value>Price of the trade</value>

		[JsonPropertyName("price")]
		public double? Price { get; set; }

		/// <summary>
		/// Size of this trade
		/// </summary>
		/// <value>Size of this trade</value>

		[JsonPropertyName("size")]
		public int? Size { get; set; }

		/// <summary>
		/// Exchange this trade happened on
		/// </summary>
		/// <value>Exchange this trade happened on</value>

		[JsonPropertyName("exchange")]
		public int? Exchange { get; set; }

		/// <summary>
		/// Condition 1 of the trade
		/// </summary>
		/// <value>Condition 1 of the trade</value>

		[JsonPropertyName("cond1")]
		public int? Cond1 { get; set; }

		/// <summary>
		/// Condition 2 of the trade
		/// </summary>
		/// <value>Condition 2 of the trade</value>

		[JsonPropertyName("cond2")]
		public int? Cond2 { get; set; }

		/// <summary>
		/// Condition 3 of the trade
		/// </summary>
		/// <value>Condition 3 of the trade</value>

		[JsonPropertyName("cond3")]
		public int? Cond3 { get; set; }

		/// <summary>
		/// Condition 4 of the trade
		/// </summary>
		/// <value>Condition 4 of the trade</value>

		[JsonPropertyName("cond4")]
		public int? Cond4 { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; set; }
	}
}

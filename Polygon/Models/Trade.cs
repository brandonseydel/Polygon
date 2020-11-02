using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Trade
	{
		/// <summary>
		/// Condition 1 of this trade
		/// </summary>
		/// <value>Condition 1 of this trade</value>

		[JsonPropertyName("c1")]
		public int? ConditionOne { get; set; }

		/// <summary>
		/// Condition 2 of this trade
		/// </summary>
		/// <value>Condition 2 of this trade</value>

		[JsonPropertyName("c2")]
		public int? ConditionTwo { get; set; }

		/// <summary>
		/// Condition 3 of this trade
		/// </summary>
		/// <value>Condition 3 of this trade</value>

		[JsonPropertyName("c3")]
		public int? ConditionThree { get; set; }

		/// <summary>
		/// Condition 4 of this trade
		/// </summary>
		/// <value>Condition 4 of this trade</value>

		[JsonPropertyName("c4")]
		public int? ConditionFour { get; set; }

		/// <summary>
		/// The exchange this trade happened on
		/// </summary>
		/// <value>The exchange this trade happened on</value>

		[JsonPropertyName("e")]
		public string Exchange { get; set; }

		/// <summary>
		/// Price of the trade
		/// </summary>
		/// <value>Price of the trade</value>

		[JsonPropertyName("p")]
		public double? Price { get; set; }

		/// <summary>
		/// Size of the trade
		/// </summary>
		/// <value>Size of the trade</value>

		[JsonPropertyName("s")]
		public int? Size { get; set; }

		/// <summary>
		/// Timestamp of this trade
		/// </summary>
		/// <value>Timestamp of this trade</value>

		[JsonPropertyName("t")]
		public long? Timestamp { get; set; }

	}
}

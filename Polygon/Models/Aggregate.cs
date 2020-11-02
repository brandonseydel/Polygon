using System.Text.Json.Serialization;

namespace Polygon.Models
{
	public class Aggregate
	{
		/// <summary>
		/// Open price
		/// </summary>
		/// <value>Open price</value>

		[JsonPropertyName("o")]
		public double? Open { get; set; }

		/// <summary>
		/// Close price
		/// </summary>
		/// <value>Close price</value>

		[JsonPropertyName("c")]
		public double? Close { get; set; }

		/// <summary>
		/// Low price
		/// </summary>
		/// <value>Low price</value>

		[JsonPropertyName("l")]
		public double? Low { get; set; }

		/// <summary>
		/// High price
		/// </summary>
		/// <value>High price</value>

		[JsonPropertyName("h")]
		public double? High { get; set; }

		/// <summary>
		/// Total Volume of all trades ( total shares exchanged )
		/// </summary>
		/// <value>Total Volume of all trades ( total shares exchanged )</value>

		[JsonPropertyName("v")]
		public int? TotalVolume { get; set; }

		/// <summary>
		/// Transactions ( 1 transaction contains X shares exchanged )
		/// </summary>
		/// <value>Transactions ( 1 transaction contains X shares exchanged )</value>

		[JsonPropertyName("k")]
		public int? NumberOfTransactions { get; set; }

		/// <summary>
		/// Timestamp of this aggregation
		/// </summary>
		/// <value>Timestamp of this aggregation</value>

		[JsonPropertyName("t")]
		public long? Timestamp { get; set; }

	}
}

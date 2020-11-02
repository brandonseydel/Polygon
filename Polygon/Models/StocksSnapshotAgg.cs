using System.Text.Json.Serialization;


namespace Polygon.Models
{

	public class StocksSnapshotAgg
	{
		/// <summary>
		/// Close price
		/// </summary>
		/// <value>Close price</value>

		[JsonPropertyName("c")]
		public double? Close { get; set; }

		/// <summary>
		/// High price
		/// </summary>
		/// <value>High price</value>

		[JsonPropertyName("h")]
		public double? High { get; set; }

		/// <summary>
		/// Low price
		/// </summary>
		/// <value>Low price</value>

		[JsonPropertyName("l")]
		public double? Low { get; set; }

		/// <summary>
		/// Open price
		/// </summary>
		/// <value>Open price</value>

		[JsonPropertyName("o")]
		public double? Open { get; set; }

		/// <summary>
		/// Volume
		/// </summary>
		/// <value>Volume</value>

		[JsonPropertyName("v")]
		public int? Volume { get; set; }

	}
}

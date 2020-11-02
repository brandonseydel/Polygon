using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class ForexAggregate
	{
		/// <summary>
		/// Open price
		/// </summary>
		/// <value>Open price</value>

		[JsonPropertyName("o")]
		public double? O { get; set; }

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
		public double? L { get; set; }

		/// <summary>
		/// High price
		/// </summary>
		/// <value>High price</value>

		[JsonPropertyName("h")]
		public double? H { get; set; }

		/// <summary>
		/// Volume of all trades ( Number of bid/asks during this timespan )
		/// </summary>
		/// <value>Volume of all trades ( Number of bid/asks during this timespan )</value>

		[JsonPropertyName("v")]
		public int? V { get; set; }

		/// <summary>
		/// Timestamp of this aggregation
		/// </summary>
		/// <value>Timestamp of this aggregation</value>

		[JsonPropertyName("t")]
		public int? T { get; set; }
	}
}

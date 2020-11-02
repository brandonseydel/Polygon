using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class InlineResponse20016LastAverage
	{
		/// <summary>
		/// Average of the trades analyzed
		/// </summary>
		/// <value>Average of the trades analyzed</value>

		[JsonPropertyName("avg")]
		public double? Avg { get; set; }

		/// <summary>
		/// Number of trades that were analyzed to get the average.
		/// </summary>
		/// <value>Number of trades that were analyzed to get the average.</value>

		[JsonPropertyName("tradesAveraged")]
		public int? TradesAveraged { get; set; }


		/// <summary>
		/// Get the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
	}
}

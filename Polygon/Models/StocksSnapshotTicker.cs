using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class StocksSnapshotTicker
	{
		/// <summary>
		/// Ticker of the object
		/// </summary>
		/// <value>Ticker of the object</value>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Gets or Sets Day
		/// </summary>

		[JsonPropertyName("day")]
		public StocksSnapshotAgg Day { get; set; }

		/// <summary>
		/// Gets or Sets LastTrade
		/// </summary>

		[JsonPropertyName("lastTrade")]
		public Trade LastTrade { get; set; }

		/// <summary>
		/// Gets or Sets LastQuote
		/// </summary>

		[JsonPropertyName("lastQuote")]
		public StocksSnapshotQuote LastQuote { get; set; }

		/// <summary>
		/// Gets or Sets Min
		/// </summary>

		[JsonPropertyName("min")]
		public StocksSnapshotAgg Min { get; set; }

		/// <summary>
		/// Gets or Sets PrevDay
		/// </summary>

		[JsonPropertyName("prevDay")]
		public StocksSnapshotAgg PrevDay { get; set; }

		/// <summary>
		/// Value of the change from previous day
		/// </summary>
		/// <value>Value of the change from previous day</value>

		[JsonPropertyName("todaysChange")]
		public double? TodaysChange { get; set; }

		/// <summary>
		/// Percentage change since previous day
		/// </summary>
		/// <value>Percentage change since previous day</value>

		[JsonPropertyName("todaysChangePerc")]
		public double? TodaysChangePerc { get; set; }

		/// <summary>
		/// Last Updated timestamp
		/// </summary>
		/// <value>Last Updated timestamp</value>

		[JsonPropertyName("updated")]
		public long? Updated { get; set; }

	}
}

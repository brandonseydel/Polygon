using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class CryptoSnapshotTicker
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
		public CryptoSnapshotAgg Day { get; set; }

		/// <summary>
		/// Gets or Sets LastTrade
		/// </summary>

		[JsonPropertyName("lastTrade")]
		public CryptoTickJson LastTrade { get; set; }

		/// <summary>
		/// Gets or Sets Min
		/// </summary>

		[JsonPropertyName("min")]
		public CryptoSnapshotAgg Min { get; set; }

		/// <summary>
		/// Gets or Sets PrevDay
		/// </summary>

		[JsonPropertyName("prevDay")]
		public CryptoSnapshotAgg PrevDay { get; set; }

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

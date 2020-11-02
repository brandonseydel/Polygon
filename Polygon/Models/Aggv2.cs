using Polygon.Helpers;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Aggv2
	{
		/// <summary>
		/// Ticker symbol
		/// </summary>
		/// <value>Ticker symbol</value>

		[JsonPropertyName("T")]
		public string Ticker { get; set; }

		/// <summary>
		/// Volume
		/// </summary>
		/// <value>Volume</value>

		[JsonPropertyName("v")]
		public double? Volume { get; set; }

		/// <summary>
		/// Open
		/// </summary>
		/// <value>Open</value>

		[JsonPropertyName("o")]
		public double? Open { get; set; }

		/// <summary>
		/// Close
		/// </summary>
		/// <value>Close</value>

		[JsonPropertyName("c")]
		public double? Close { get; set; }

		/// <summary>
		/// High
		/// </summary>
		/// <value>High</value>

		[JsonPropertyName("h")]
		public double? High { get; set; }

		/// <summary>
		/// Low
		/// </summary>
		/// <value>Low</value>

		[JsonPropertyName("l")]
		public double? Low { get; set; }

		/// <summary>
		/// Unix Msec Timestamp ( Start of Aggregate window )
		/// </summary>
		/// <value>Unix Msec Timestamp ( Start of Aggregate window )</value>

		[JsonPropertyName("t")]
		public long? StartOfAggregateWindowUnixTimestamp { get; set; }

		public System.DateTime? StartTimeOfWindow { get => this.StartOfAggregateWindowUnixTimestamp.GetUTCTimeFromUnixTimestamp(); }

		/// <summary>
		/// Number of items in aggregate window
		/// </summary>
		/// <value>Number of items in aggregate window</value>

		[JsonPropertyName("n")]
		public decimal? NumberOfItems { get; set; }
	}
}

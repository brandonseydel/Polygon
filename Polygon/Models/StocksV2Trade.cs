using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class StocksV2Trade
	{
		/// <summary>
		/// Ticker of the object
		/// </summary>
		/// <value>Ticker of the object</value>

		[JsonPropertyName("T")]
		public string Ticker { get; set; }

		/// <summary>
		/// Nanosecond accuracy SIP Unix Timestamp
		/// </summary>
		/// <value>Nanosecond accuracy SIP Unix Timestamp</value>

		[JsonPropertyName("t")]
		public long? TimestampSIPUnix { get; set; }

		/// <summary>
		/// Nanosecond accuracy Participant/Exchange Unix Timestamp
		/// </summary>
		/// <value>Nanosecond accuracy Participant/Exchange Unix Timestamp</value>

		[JsonPropertyName("y")]
		public long? TimestampExchangeUnix { get; set; }

		/// <summary>
		/// Nanosecond accuracy TRF(Trade Reporting Facility) Unix Timestamp
		/// </summary>
		/// <value>Nanosecond accuracy TRF(Trade Reporting Facility) Unix Timestamp</value>

		[JsonPropertyName("f")]
		public long? TimestampFacilityUnix { get; set; }

		/// <summary>
		/// Sequence Number
		/// </summary>
		/// <value>Sequence Number</value>

		[JsonPropertyName("q")]
		public int? SequenceNumber { get; set; }

		/// <summary>
		/// Trade ID
		/// </summary>
		/// <value>Trade ID</value>

		[JsonPropertyName("i")]
		public string TradeId { get; set; }

		/// <summary>
		/// Exchange ID
		/// </summary>
		/// <value>Exchange ID</value>

		[JsonPropertyName("x")]
		public int? ExchangeId { get; set; }

		/// <summary>
		/// Size/Volume of the trade
		/// </summary>
		/// <value>Size/Volume of the trade</value>

		[JsonPropertyName("s")]
		public int? Volume { get; set; }

		/// <summary>
		/// Conditions
		/// </summary>
		/// <value>Conditions</value>

		[JsonPropertyName("c")]
		public List<int?> Conditions { get; set; }

		/// <summary>
		/// Price of the trade
		/// </summary>
		/// <value>Price of the trade</value>

		[JsonPropertyName("p")]
		public double? Price { get; set; }

		/// <summary>
		/// Tape where trade occurred. ( 1,2 = CTA, 3 = UTP )
		/// </summary>
		/// <value>Tape where trade occurred. ( 1,2 = CTA, 3 = UTP )</value>

		[JsonPropertyName("z")]
		public int? Tape { get; set; }

	}
}

using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class StocksV2NBBO
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
		/// Conditions
		/// </summary>
		/// <value>Conditions</value>

		[JsonPropertyName("c")]
		public List<int?> Conditions { get; set; }

		/// <summary>
		/// Indicators
		/// </summary>
		/// <value>Indicators</value>

		[JsonPropertyName("i")]
		public List<int?> Indicators { get; set; }

		/// <summary>
		/// BID Price
		/// </summary>
		/// <value>BID Price</value>

		[JsonPropertyName("p")]
		public double? BidPrice { get; set; }

		/// <summary>
		/// BID Exchange ID
		/// </summary>
		/// <value>BID Exchange ID</value>

		[JsonPropertyName("x")]
		public int? BidExchangeId { get; set; }

		/// <summary>
		/// BID Size ( In round lots )
		/// </summary>
		/// <value>BID Size ( In round lots )</value>

		[JsonPropertyName("s")]
		public int? BidSize { get; set; }

		/// <summary>
		/// ASK Price
		/// </summary>
		/// <value>ASK Price</value>

		[JsonPropertyName("P")]
		public double? AskPrice { get; set; }

		/// <summary>
		/// ASK Exchange ID
		/// </summary>
		/// <value>ASK Exchange ID</value>

		[JsonPropertyName("X")]
		public int? AskPriceExchange { get; set; }

		/// <summary>
		/// ASK Size ( In round lots )
		/// </summary>
		/// <value>ASK Size ( In round lots )</value>

		[JsonPropertyName("S")]
		public int? AskSize { get; set; }

		/// <summary>
		/// Tape where trade occurred. ( 1,2 = CTA, 3 = UTP )
		/// </summary>
		/// <value>Tape where trade occurred. ( 1,2 = CTA, 3 = UTP )</value>

		[JsonPropertyName("z")]
		public int? TapeOccurred { get; set; }
	}
}

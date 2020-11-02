using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class MarketHoliday
	{
		/// <summary>
		/// Which market this record is for
		/// </summary>
		/// <value>Which market this record is for</value>

		[JsonPropertyName("exchange")]
		public string Exchange { get; set; }

		/// <summary>
		/// Human readable description of the holiday
		/// </summary>
		/// <value>Human readable description of the holiday</value>

		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Status of the market on this holiday
		/// </summary>
		/// <value>Status of the market on this holiday</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Date of this holiday
		/// </summary>
		/// <value>Date of this holiday</value>

		[JsonPropertyName("date")]
		public DateTime? Date { get; set; }

		/// <summary>
		/// Market open time on this holiday ( if it's not closed )
		/// </summary>
		/// <value>Market open time on this holiday ( if it's not closed )</value>

		[JsonPropertyName("open")]
		public DateTime? Open { get; set; }

		/// <summary>
		/// Market close time on this holiday ( if it's not closed )
		/// </summary>
		/// <value>Market close time on this holiday ( if it's not closed )</value>

		[JsonPropertyName("close")]
		public DateTime? Close { get; set; }
	}
}

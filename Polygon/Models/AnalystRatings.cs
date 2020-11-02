using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class AnalystRatings
	{
		/// <summary>
		/// Symbol which we are requesting ratings
		/// </summary>
		/// <value>Symbol which we are requesting ratings</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Number of analysts reporting
		/// </summary>
		/// <value>Number of analysts reporting</value>

		[JsonPropertyName("analysts")]
		public decimal? Analysts { get; set; }

		/// <summary>
		/// Change from last month to current
		/// </summary>
		/// <value>Change from last month to current</value>

		[JsonPropertyName("change")]
		public double? Change { get; set; }

		/// <summary>
		/// Gets or Sets StrongBuy
		/// </summary>

		[JsonPropertyName("strongBuy")]
		public RatingSection StrongBuy { get; set; }

		/// <summary>
		/// Gets or Sets Buy
		/// </summary>

		[JsonPropertyName("buy")]
		public RatingSection Buy { get; set; }

		/// <summary>
		/// Gets or Sets Hold
		/// </summary>

		[JsonPropertyName("hold")]
		public RatingSection Hold { get; set; }

		/// <summary>
		/// Gets or Sets Sell
		/// </summary>

		[JsonPropertyName("sell")]
		public RatingSection Sell { get; set; }

		/// <summary>
		/// Gets or Sets StrongSell
		/// </summary>

		[JsonPropertyName("strongSell")]
		public RatingSection StrongSell { get; set; }

		/// <summary>
		/// Last time the ratings for this symbol were updated.
		/// </summary>
		/// <value>Last time the ratings for this symbol were updated.</value>

		[JsonPropertyName("updated")]
		public DateTime? Updated { get; set; }


		/// <summary>
		/// Get the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
	}
}

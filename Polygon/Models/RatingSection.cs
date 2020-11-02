using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class RatingSection
	{
		/// <summary>
		/// Analyst Rating at current month
		/// </summary>
		/// <value>Analyst Rating at current month</value>

		[JsonPropertyName("current")]
		public decimal? Current { get; set; }

		/// <summary>
		/// Analyst Ratings at 1 month in the future
		/// </summary>
		/// <value>Analyst Ratings at 1 month in the future</value>

		[JsonPropertyName("month1")]
		public decimal? Month1 { get; set; }

		/// <summary>
		/// Analyst Ratings at 2 month in the future
		/// </summary>
		/// <value>Analyst Ratings at 2 month in the future</value>

		[JsonPropertyName("month2")]
		public decimal? Month2 { get; set; }

		/// <summary>
		/// Analyst Ratings at 3 month in the future
		/// </summary>
		/// <value>Analyst Ratings at 3 month in the future</value>

		[JsonPropertyName("month3")]
		public decimal? Month3 { get; set; }

		/// <summary>
		/// Analyst Ratings at 4 month in the future
		/// </summary>
		/// <value>Analyst Ratings at 4 month in the future</value>

		[JsonPropertyName("month4")]
		public decimal? Month4 { get; set; }

		/// <summary>
		/// Analyst Ratings at 5 month in the future
		/// </summary>
		/// <value>Analyst Ratings at 5 month in the future</value>

		[JsonPropertyName("month5")]
		public decimal? Month5 { get; set; }

	}
}

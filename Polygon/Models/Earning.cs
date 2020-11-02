using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Earning
	{
		/// <summary>
		/// Stock Symbol
		/// </summary>
		/// <value>Stock Symbol</value>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Report Date
		/// </summary>
		/// <value>Report Date</value>

		[JsonPropertyName("EPSReportDate")]
		public DateTime? EPSReportDate { get; set; }

		/// <summary>
		/// Report date as non date format
		/// </summary>
		/// <value>Report date as non date format</value>

		[JsonPropertyName("EPSReportDateStr")]
		public string EPSReportDateStr { get; set; }

		/// <summary>
		/// Gets or Sets FiscalPeriod
		/// </summary>

		[JsonPropertyName("fiscalPeriod")]
		public string FiscalPeriod { get; set; }

		/// <summary>
		/// Gets or Sets FiscalEndDate
		/// </summary>

		[JsonPropertyName("fiscalEndDate")]
		public DateTime? FiscalEndDate { get; set; }

		/// <summary>
		/// Gets or Sets ActualEPS
		/// </summary>

		[JsonPropertyName("actualEPS")]
		public double? ActualEPS { get; set; }

		/// <summary>
		/// Gets or Sets ConsensusEPS
		/// </summary>

		[JsonPropertyName("consensusEPS")]
		public double? ConsensusEPS { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedEPS
		/// </summary>

		[JsonPropertyName("estimatedEPS")]
		public double? EstimatedEPS { get; set; }

		/// <summary>
		/// Gets or Sets AnnounceTime
		/// </summary>

		[JsonPropertyName("announceTime")]
		public string AnnounceTime { get; set; }

		/// <summary>
		/// Gets or Sets NumberOfEstimates
		/// </summary>

		[JsonPropertyName("numberOfEstimates")]
		public int? NumberOfEstimates { get; set; }

		/// <summary>
		/// Gets or Sets EPSSurpriseDollar
		/// </summary>

		[JsonPropertyName("EPSSurpriseDollar")]
		public double? EPSSurpriseDollar { get; set; }

		/// <summary>
		/// Gets or Sets YearAgo
		/// </summary>

		[JsonPropertyName("yearAgo")]
		public double? YearAgo { get; set; }

		/// <summary>
		/// Gets or Sets YearAgoChangePercent
		/// </summary>

		[JsonPropertyName("yearAgoChangePercent")]
		public double? YearAgoChangePercent { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedChangePercent
		/// </summary>

		[JsonPropertyName("estimatedChangePercent")]
		public double? EstimatedChangePercent { get; set; }
	}
}

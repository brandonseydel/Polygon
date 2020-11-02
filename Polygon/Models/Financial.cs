using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Financial
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

		[JsonPropertyName("reportDate")]
		public DateTime? ReportDate { get; set; }

		/// <summary>
		/// Report date as non date format
		/// </summary>
		/// <value>Report date as non date format</value>

		[JsonPropertyName("reportDateStr")]
		public string ReportDateStr { get; set; }

		/// <summary>
		/// Gets or Sets GrossProfit
		/// </summary>

		[JsonPropertyName("grossProfit")]
		public int? GrossProfit { get; set; }

		/// <summary>
		/// Gets or Sets CostOfRevenue
		/// </summary>

		[JsonPropertyName("costOfRevenue")]
		public int? CostOfRevenue { get; set; }

		/// <summary>
		/// Gets or Sets OperatingRevenue
		/// </summary>

		[JsonPropertyName("operatingRevenue")]
		public int? OperatingRevenue { get; set; }

		/// <summary>
		/// Gets or Sets TotalRevenue
		/// </summary>

		[JsonPropertyName("totalRevenue")]
		public int? TotalRevenue { get; set; }

		/// <summary>
		/// Gets or Sets OperatingIncome
		/// </summary>

		[JsonPropertyName("operatingIncome")]
		public int? OperatingIncome { get; set; }

		/// <summary>
		/// Gets or Sets NetIncome
		/// </summary>

		[JsonPropertyName("netIncome")]
		public int? NetIncome { get; set; }

		/// <summary>
		/// Gets or Sets ResearchAndDevelopment
		/// </summary>

		[JsonPropertyName("researchAndDevelopment")]
		public int? ResearchAndDevelopment { get; set; }

		/// <summary>
		/// Gets or Sets OperatingExpense
		/// </summary>

		[JsonPropertyName("operatingExpense")]
		public int? OperatingExpense { get; set; }

		/// <summary>
		/// Gets or Sets CurrentAssets
		/// </summary>

		[JsonPropertyName("currentAssets")]
		public int? CurrentAssets { get; set; }

		/// <summary>
		/// Gets or Sets TotalAssets
		/// </summary>

		[JsonPropertyName("totalAssets")]
		public int? TotalAssets { get; set; }

		/// <summary>
		/// Gets or Sets TotalLiabilities
		/// </summary>

		[JsonPropertyName("totalLiabilities")]
		public int? TotalLiabilities { get; set; }

		/// <summary>
		/// Gets or Sets CurrentCash
		/// </summary>

		[JsonPropertyName("currentCash")]
		public int? CurrentCash { get; set; }

		/// <summary>
		/// Gets or Sets CurrentDebt
		/// </summary>

		[JsonPropertyName("currentDebt")]
		public int? CurrentDebt { get; set; }

		/// <summary>
		/// Gets or Sets TotalCash
		/// </summary>

		[JsonPropertyName("totalCash")]
		public int? TotalCash { get; set; }

		/// <summary>
		/// Gets or Sets TotalDebt
		/// </summary>

		[JsonPropertyName("totalDebt")]
		public int? TotalDebt { get; set; }

		/// <summary>
		/// Gets or Sets ShareholderEquity
		/// </summary>

		[JsonPropertyName("shareholderEquity")]
		public int? ShareholderEquity { get; set; }

		/// <summary>
		/// Gets or Sets CashChange
		/// </summary>

		[JsonPropertyName("cashChange")]
		public int? CashChange { get; set; }

		/// <summary>
		/// Gets or Sets CashFlow
		/// </summary>

		[JsonPropertyName("cashFlow")]
		public int? CashFlow { get; set; }

		/// <summary>
		/// Gets or Sets OperatingGainsLosses
		/// </summary>

		[JsonPropertyName("operatingGainsLosses")]
		public decimal? OperatingGainsLosses { get; set; }
	}
}

using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Financials
	{
		/// <summary>
		/// Gets or Sets Ticker
		/// </summary>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Reporting period.
		/// </summary>
		/// <value>Reporting period.</value>

		[JsonPropertyName("period")]
		public string Period { get; set; }

		/// <summary>
		/// Gets or Sets CalendarDate
		/// </summary>

		[JsonPropertyName("calendarDate")]
		public DateTime? CalendarDate { get; set; }

		/// <summary>
		/// Gets or Sets ReportPeriod
		/// </summary>

		[JsonPropertyName("reportPeriod")]
		public DateTime? ReportPeriod { get; set; }

		/// <summary>
		/// Gets or Sets Updated
		/// </summary>

		[JsonPropertyName("updated")]
		public DateTime? Updated { get; set; }

		/// <summary>
		/// Gets or Sets AccumulatedOtherComprehensiveIncome
		/// </summary>

		[JsonPropertyName("accumulatedOtherComprehensiveIncome")]
		public int? AccumulatedOtherComprehensiveIncome { get; set; }

		/// <summary>
		/// Gets or Sets Assets
		/// </summary>

		[JsonPropertyName("assets")]
		public int? Assets { get; set; }

		/// <summary>
		/// Gets or Sets AssetsAverage
		/// </summary>

		[JsonPropertyName("assetsAverage")]
		public int? AssetsAverage { get; set; }

		/// <summary>
		/// Gets or Sets AssetsCurrent
		/// </summary>

		[JsonPropertyName("assetsCurrent")]
		public int? AssetsCurrent { get; set; }

		/// <summary>
		/// Gets or Sets AssetTurnover
		/// </summary>

		[JsonPropertyName("assetTurnover")]
		public int? AssetTurnover { get; set; }

		/// <summary>
		/// Gets or Sets AssetsNonCurrent
		/// </summary>

		[JsonPropertyName("assetsNonCurrent")]
		public int? AssetsNonCurrent { get; set; }

		/// <summary>
		/// Gets or Sets BookValuePerShare
		/// </summary>

		[JsonPropertyName("bookValuePerShare")]
		public double? BookValuePerShare { get; set; }

		/// <summary>
		/// Gets or Sets CapitalExpenditure
		/// </summary>

		[JsonPropertyName("capitalExpenditure")]
		public int? CapitalExpenditure { get; set; }

		/// <summary>
		/// Gets or Sets CashAndEquivalents
		/// </summary>

		[JsonPropertyName("cashAndEquivalents")]
		public int? CashAndEquivalents { get; set; }

		/// <summary>
		/// Gets or Sets CashAndEquivalentsUSD
		/// </summary>

		[JsonPropertyName("cashAndEquivalentsUSD")]
		public int? CashAndEquivalentsUSD { get; set; }

		/// <summary>
		/// Gets or Sets CostOfRevenue
		/// </summary>

		[JsonPropertyName("costOfRevenue")]
		public int? CostOfRevenue { get; set; }

		/// <summary>
		/// Gets or Sets ConsolidatedIncome
		/// </summary>

		[JsonPropertyName("consolidatedIncome")]
		public int? ConsolidatedIncome { get; set; }

		/// <summary>
		/// Gets or Sets CurrentRatio
		/// </summary>

		[JsonPropertyName("currentRatio")]
		public double? CurrentRatio { get; set; }

		/// <summary>
		/// Gets or Sets DebtToEquityRatio
		/// </summary>

		[JsonPropertyName("debtToEquityRatio")]
		public double? DebtToEquityRatio { get; set; }

		/// <summary>
		/// Gets or Sets Debt
		/// </summary>

		[JsonPropertyName("debt")]
		public int? Debt { get; set; }

		/// <summary>
		/// Gets or Sets DebtCurrent
		/// </summary>

		[JsonPropertyName("debtCurrent")]
		public int? DebtCurrent { get; set; }

		/// <summary>
		/// Gets or Sets DebtNonCurrent
		/// </summary>

		[JsonPropertyName("debtNonCurrent")]
		public int? DebtNonCurrent { get; set; }

		/// <summary>
		/// Gets or Sets DebtUSD
		/// </summary>

		[JsonPropertyName("debtUSD")]
		public int? DebtUSD { get; set; }

		/// <summary>
		/// Gets or Sets DeferredRevenue
		/// </summary>

		[JsonPropertyName("deferredRevenue")]
		public int? DeferredRevenue { get; set; }

		/// <summary>
		/// Gets or Sets DepreciationAmortizationAndAccretion
		/// </summary>

		[JsonPropertyName("depreciationAmortizationAndAccretion")]
		public int? DepreciationAmortizationAndAccretion { get; set; }

		/// <summary>
		/// Gets or Sets Deposits
		/// </summary>

		[JsonPropertyName("deposits")]
		public int? Deposits { get; set; }

		/// <summary>
		/// Gets or Sets DividendYield
		/// </summary>

		[JsonPropertyName("dividendYield")]
		public int? DividendYield { get; set; }

		/// <summary>
		/// Gets or Sets DividendsPerBasicCommonShare
		/// </summary>

		[JsonPropertyName("dividendsPerBasicCommonShare")]
		public int? DividendsPerBasicCommonShare { get; set; }

		/// <summary>
		/// Gets or Sets EarningBeforeInterestTaxes
		/// </summary>

		[JsonPropertyName("earningBeforeInterestTaxes")]
		public int? EarningBeforeInterestTaxes { get; set; }

		/// <summary>
		/// Gets or Sets EarningsBeforeInterestTaxesDepreciationAmortization
		/// </summary>

		[JsonPropertyName("earningsBeforeInterestTaxesDepreciationAmortization")]
		public int? EarningsBeforeInterestTaxesDepreciationAmortization { get; set; }

		/// <summary>
		/// Gets or Sets EBITDAMargin
		/// </summary>

		[JsonPropertyName("EBITDAMargin")]
		public double? EBITDAMargin { get; set; }

		/// <summary>
		/// Gets or Sets EarningsBeforeInterestTaxesDepreciationAmortizationUSD
		/// </summary>

		[JsonPropertyName("earningsBeforeInterestTaxesDepreciationAmortizationUSD")]
		public int? EarningsBeforeInterestTaxesDepreciationAmortizationUSD { get; set; }

		/// <summary>
		/// Gets or Sets EarningBeforeInterestTaxesUSD
		/// </summary>

		[JsonPropertyName("earningBeforeInterestTaxesUSD")]
		public int? EarningBeforeInterestTaxesUSD { get; set; }

		/// <summary>
		/// Gets or Sets EarningsBeforeTax
		/// </summary>

		[JsonPropertyName("earningsBeforeTax")]
		public int? EarningsBeforeTax { get; set; }

		/// <summary>
		/// Gets or Sets EarningsPerBasicShare
		/// </summary>

		[JsonPropertyName("earningsPerBasicShare")]
		public double? EarningsPerBasicShare { get; set; }

		/// <summary>
		/// Gets or Sets EarningsPerDilutedShare
		/// </summary>

		[JsonPropertyName("earningsPerDilutedShare")]
		public double? EarningsPerDilutedShare { get; set; }

		/// <summary>
		/// Gets or Sets EarningsPerBasicShareUSD
		/// </summary>

		[JsonPropertyName("earningsPerBasicShareUSD")]
		public double? EarningsPerBasicShareUSD { get; set; }

		/// <summary>
		/// Gets or Sets ShareholdersEquity
		/// </summary>

		[JsonPropertyName("shareholdersEquity")]
		public int? ShareholdersEquity { get; set; }

		/// <summary>
		/// Gets or Sets AverageEquity
		/// </summary>

		[JsonPropertyName("averageEquity")]
		public int? AverageEquity { get; set; }

		/// <summary>
		/// Gets or Sets ShareholdersEquityUSD
		/// </summary>

		[JsonPropertyName("shareholdersEquityUSD")]
		public int? ShareholdersEquityUSD { get; set; }

		/// <summary>
		/// Gets or Sets EnterpriseValue
		/// </summary>

		[JsonPropertyName("enterpriseValue")]
		public int? EnterpriseValue { get; set; }

		/// <summary>
		/// Gets or Sets EnterpriseValueOverEBIT
		/// </summary>

		[JsonPropertyName("enterpriseValueOverEBIT")]
		public int? EnterpriseValueOverEBIT { get; set; }

		/// <summary>
		/// Gets or Sets EnterpriseValueOverEBITDA
		/// </summary>

		[JsonPropertyName("enterpriseValueOverEBITDA")]
		public double? EnterpriseValueOverEBITDA { get; set; }

		/// <summary>
		/// Gets or Sets FreeCashFlow
		/// </summary>

		[JsonPropertyName("freeCashFlow")]
		public int? FreeCashFlow { get; set; }

		/// <summary>
		/// Gets or Sets FreeCashFlowPerShare
		/// </summary>

		[JsonPropertyName("freeCashFlowPerShare")]
		public double? FreeCashFlowPerShare { get; set; }

		/// <summary>
		/// Gets or Sets ForeignCurrencyUSDExchangeRate
		/// </summary>

		[JsonPropertyName("foreignCurrencyUSDExchangeRate")]
		public int? ForeignCurrencyUSDExchangeRate { get; set; }

		/// <summary>
		/// Gets or Sets GrossProfit
		/// </summary>

		[JsonPropertyName("grossProfit")]
		public int? GrossProfit { get; set; }

		/// <summary>
		/// Gets or Sets GrossMargin
		/// </summary>

		[JsonPropertyName("grossMargin")]
		public double? GrossMargin { get; set; }

		/// <summary>
		/// Gets or Sets GoodwillAndIntangibleAssets
		/// </summary>

		[JsonPropertyName("goodwillAndIntangibleAssets")]
		public int? GoodwillAndIntangibleAssets { get; set; }

		/// <summary>
		/// Gets or Sets InterestExpense
		/// </summary>

		[JsonPropertyName("interestExpense")]
		public int? InterestExpense { get; set; }

		/// <summary>
		/// Gets or Sets InvestedCapital
		/// </summary>

		[JsonPropertyName("investedCapital")]
		public int? InvestedCapital { get; set; }

		/// <summary>
		/// Gets or Sets InvestedCapitalAverage
		/// </summary>

		[JsonPropertyName("investedCapitalAverage")]
		public int? InvestedCapitalAverage { get; set; }

		/// <summary>
		/// Gets or Sets Inventory
		/// </summary>

		[JsonPropertyName("inventory")]
		public int? Inventory { get; set; }

		/// <summary>
		/// Gets or Sets Investments
		/// </summary>

		[JsonPropertyName("investments")]
		public int? Investments { get; set; }

		/// <summary>
		/// Gets or Sets InvestmentsCurrent
		/// </summary>

		[JsonPropertyName("investmentsCurrent")]
		public int? InvestmentsCurrent { get; set; }

		/// <summary>
		/// Gets or Sets InvestmentsNonCurrent
		/// </summary>

		[JsonPropertyName("investmentsNonCurrent")]
		public int? InvestmentsNonCurrent { get; set; }

		/// <summary>
		/// Gets or Sets TotalLiabilities
		/// </summary>

		[JsonPropertyName("totalLiabilities")]
		public int? TotalLiabilities { get; set; }

		/// <summary>
		/// Gets or Sets CurrentLiabilities
		/// </summary>

		[JsonPropertyName("currentLiabilities")]
		public int? CurrentLiabilities { get; set; }

		/// <summary>
		/// Gets or Sets LiabilitiesNonCurrent
		/// </summary>

		[JsonPropertyName("liabilitiesNonCurrent")]
		public int? LiabilitiesNonCurrent { get; set; }

		/// <summary>
		/// Gets or Sets MarketCapitalization
		/// </summary>

		[JsonPropertyName("marketCapitalization")]
		public int? MarketCapitalization { get; set; }

		/// <summary>
		/// Gets or Sets NetCashFlow
		/// </summary>

		[JsonPropertyName("netCashFlow")]
		public int? NetCashFlow { get; set; }

		/// <summary>
		/// Gets or Sets NetCashFlowBusinessAcquisitionsDisposals
		/// </summary>

		[JsonPropertyName("netCashFlowBusinessAcquisitionsDisposals")]
		public int? NetCashFlowBusinessAcquisitionsDisposals { get; set; }

		/// <summary>
		/// Gets or Sets IssuanceEquityShares
		/// </summary>

		[JsonPropertyName("issuanceEquityShares")]
		public int? IssuanceEquityShares { get; set; }

		/// <summary>
		/// Gets or Sets IssuanceDebtSecurities
		/// </summary>

		[JsonPropertyName("issuanceDebtSecurities")]
		public int? IssuanceDebtSecurities { get; set; }

		/// <summary>
		/// Gets or Sets PaymentDividendsOtherCashDistributions
		/// </summary>

		[JsonPropertyName("paymentDividendsOtherCashDistributions")]
		public int? PaymentDividendsOtherCashDistributions { get; set; }

		/// <summary>
		/// Gets or Sets NetCashFlowFromFinancing
		/// </summary>

		[JsonPropertyName("netCashFlowFromFinancing")]
		public int? NetCashFlowFromFinancing { get; set; }

		/// <summary>
		/// Gets or Sets NetCashFlowFromInvesting
		/// </summary>

		[JsonPropertyName("netCashFlowFromInvesting")]
		public int? NetCashFlowFromInvesting { get; set; }

		/// <summary>
		/// Gets or Sets NetCashFlowInvestmentAcquisitionsDisposals
		/// </summary>

		[JsonPropertyName("netCashFlowInvestmentAcquisitionsDisposals")]
		public int? NetCashFlowInvestmentAcquisitionsDisposals { get; set; }

		/// <summary>
		/// Gets or Sets NetCashFlowFromOperations
		/// </summary>

		[JsonPropertyName("netCashFlowFromOperations")]
		public int? NetCashFlowFromOperations { get; set; }

		/// <summary>
		/// Gets or Sets EffectOfExchangeRateChangesOnCash
		/// </summary>

		[JsonPropertyName("effectOfExchangeRateChangesOnCash")]
		public int? EffectOfExchangeRateChangesOnCash { get; set; }

		/// <summary>
		/// Gets or Sets NetIncome
		/// </summary>

		[JsonPropertyName("netIncome")]
		public int? NetIncome { get; set; }

		/// <summary>
		/// Gets or Sets NetIncomeCommonStock
		/// </summary>

		[JsonPropertyName("netIncomeCommonStock")]
		public int? NetIncomeCommonStock { get; set; }

		/// <summary>
		/// Gets or Sets NetIncomeCommonStockUSD
		/// </summary>

		[JsonPropertyName("netIncomeCommonStockUSD")]
		public int? NetIncomeCommonStockUSD { get; set; }

		/// <summary>
		/// Gets or Sets NetLossIncomeFromDiscontinuedOperations
		/// </summary>

		[JsonPropertyName("netLossIncomeFromDiscontinuedOperations")]
		public int? NetLossIncomeFromDiscontinuedOperations { get; set; }

		/// <summary>
		/// Gets or Sets NetIncomeToNonControllingInterests
		/// </summary>

		[JsonPropertyName("netIncomeToNonControllingInterests")]
		public int? NetIncomeToNonControllingInterests { get; set; }

		/// <summary>
		/// Gets or Sets ProfitMargin
		/// </summary>

		[JsonPropertyName("profitMargin")]
		public double? ProfitMargin { get; set; }

		/// <summary>
		/// Gets or Sets OperatingExpenses
		/// </summary>

		[JsonPropertyName("operatingExpenses")]
		public int? OperatingExpenses { get; set; }

		/// <summary>
		/// Gets or Sets OperatingIncome
		/// </summary>

		[JsonPropertyName("operatingIncome")]
		public int? OperatingIncome { get; set; }

		/// <summary>
		/// Gets or Sets TradeAndNonTradePayables
		/// </summary>

		[JsonPropertyName("tradeAndNonTradePayables")]
		public int? TradeAndNonTradePayables { get; set; }

		/// <summary>
		/// Gets or Sets PayoutRatio
		/// </summary>

		[JsonPropertyName("payoutRatio")]
		public int? PayoutRatio { get; set; }

		/// <summary>
		/// Gets or Sets PriceToBookValue
		/// </summary>

		[JsonPropertyName("priceToBookValue")]
		public double? PriceToBookValue { get; set; }

		/// <summary>
		/// Gets or Sets PriceEarnings
		/// </summary>

		[JsonPropertyName("priceEarnings")]
		public double? PriceEarnings { get; set; }

		/// <summary>
		/// Gets or Sets PriceToEarningsRatio
		/// </summary>

		[JsonPropertyName("priceToEarningsRatio")]
		public double? PriceToEarningsRatio { get; set; }

		/// <summary>
		/// Gets or Sets PropertyPlantEquipmentNet
		/// </summary>

		[JsonPropertyName("propertyPlantEquipmentNet")]
		public int? PropertyPlantEquipmentNet { get; set; }

		/// <summary>
		/// Gets or Sets PreferredDividendsIncomeStatementImpact
		/// </summary>

		[JsonPropertyName("preferredDividendsIncomeStatementImpact")]
		public int? PreferredDividendsIncomeStatementImpact { get; set; }

		/// <summary>
		/// Gets or Sets SharePriceAdjustedClose
		/// </summary>

		[JsonPropertyName("sharePriceAdjustedClose")]
		public double? SharePriceAdjustedClose { get; set; }

		/// <summary>
		/// Gets or Sets PriceSales
		/// </summary>

		[JsonPropertyName("priceSales")]
		public double? PriceSales { get; set; }

		/// <summary>
		/// Gets or Sets PriceToSalesRatio
		/// </summary>

		[JsonPropertyName("priceToSalesRatio")]
		public double? PriceToSalesRatio { get; set; }

		/// <summary>
		/// Gets or Sets TradeAndNonTradeReceivables
		/// </summary>

		[JsonPropertyName("tradeAndNonTradeReceivables")]
		public int? TradeAndNonTradeReceivables { get; set; }

		/// <summary>
		/// Gets or Sets AccumulatedRetainedEarningsDeficit
		/// </summary>

		[JsonPropertyName("accumulatedRetainedEarningsDeficit")]
		public int? AccumulatedRetainedEarningsDeficit { get; set; }

		/// <summary>
		/// Gets or Sets Revenues
		/// </summary>

		[JsonPropertyName("revenues")]
		public int? Revenues { get; set; }

		/// <summary>
		/// Gets or Sets RevenuesUSD
		/// </summary>

		[JsonPropertyName("revenuesUSD")]
		public int? RevenuesUSD { get; set; }

		/// <summary>
		/// Gets or Sets ResearchAndDevelopmentExpense
		/// </summary>

		[JsonPropertyName("researchAndDevelopmentExpense")]
		public int? ResearchAndDevelopmentExpense { get; set; }

		/// <summary>
		/// Gets or Sets ReturnOnAverageAssets
		/// </summary>

		[JsonPropertyName("returnOnAverageAssets")]
		public int? ReturnOnAverageAssets { get; set; }

		/// <summary>
		/// Gets or Sets ReturnOnAverageEquity
		/// </summary>

		[JsonPropertyName("returnOnAverageEquity")]
		public int? ReturnOnAverageEquity { get; set; }

		/// <summary>
		/// Gets or Sets ReturnOnInvestedCapital
		/// </summary>

		[JsonPropertyName("returnOnInvestedCapital")]
		public int? ReturnOnInvestedCapital { get; set; }

		/// <summary>
		/// Gets or Sets ReturnOnSales
		/// </summary>

		[JsonPropertyName("returnOnSales")]
		public double? ReturnOnSales { get; set; }

		/// <summary>
		/// Gets or Sets ShareBasedCompensation
		/// </summary>

		[JsonPropertyName("shareBasedCompensation")]
		public int? ShareBasedCompensation { get; set; }

		/// <summary>
		/// Gets or Sets SellingGeneralAndAdministrativeExpense
		/// </summary>

		[JsonPropertyName("sellingGeneralAndAdministrativeExpense")]
		public int? SellingGeneralAndAdministrativeExpense { get; set; }

		/// <summary>
		/// Gets or Sets ShareFactor
		/// </summary>

		[JsonPropertyName("shareFactor")]
		public int? ShareFactor { get; set; }

		/// <summary>
		/// Gets or Sets Shares
		/// </summary>

		[JsonPropertyName("shares")]
		public int? Shares { get; set; }

		/// <summary>
		/// Gets or Sets WeightedAverageShares
		/// </summary>

		[JsonPropertyName("weightedAverageShares")]
		public int? WeightedAverageShares { get; set; }

		/// <summary>
		/// Gets or Sets WeightedAverageSharesDiluted
		/// </summary>

		[JsonPropertyName("weightedAverageSharesDiluted")]
		public int? WeightedAverageSharesDiluted { get; set; }

		/// <summary>
		/// Gets or Sets SalesPerShare
		/// </summary>

		[JsonPropertyName("salesPerShare")]
		public double? SalesPerShare { get; set; }

		/// <summary>
		/// Gets or Sets TangibleAssetValue
		/// </summary>

		[JsonPropertyName("tangibleAssetValue")]
		public int? TangibleAssetValue { get; set; }

		/// <summary>
		/// Gets or Sets TaxAssets
		/// </summary>

		[JsonPropertyName("taxAssets")]
		public int? TaxAssets { get; set; }

		/// <summary>
		/// Gets or Sets IncomeTaxExpense
		/// </summary>

		[JsonPropertyName("incomeTaxExpense")]
		public int? IncomeTaxExpense { get; set; }

		/// <summary>
		/// Gets or Sets TaxLiabilities
		/// </summary>

		[JsonPropertyName("taxLiabilities")]
		public int? TaxLiabilities { get; set; }

		/// <summary>
		/// Gets or Sets TangibleAssetsBookValuePerShare
		/// </summary>

		[JsonPropertyName("tangibleAssetsBookValuePerShare")]
		public double? TangibleAssetsBookValuePerShare { get; set; }

		/// <summary>
		/// Gets or Sets WorkingCapital
		/// </summary>

		[JsonPropertyName("workingCapital")]
		public int? WorkingCapital { get; set; }
	}
}

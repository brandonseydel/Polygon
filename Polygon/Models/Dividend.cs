using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Dividend
	{
		/// <summary>
		/// Gets or Sets Symbol
		/// </summary>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Refers to the dividend payment type<br/> - Dividend income<br/> - Interest income<br/> - Stock dividend<br/> - Short term capital gain<br/> - Medium term capital gain<br/> - Long term capital gain<br/> - Unspecified term capital gain<br/> 
		/// </summary>
		/// <value>Refers to the dividend payment type<br/> - Dividend income<br/> - Interest income<br/> - Stock dividend<br/> - Short term capital gain<br/> - Medium term capital gain<br/> - Long term capital gain<br/> - Unspecified term capital gain<br/> </value>

		[JsonPropertyName("type")]
		public string Type { get; set; }

		/// <summary>
		/// Execution date of the trade
		/// </summary>
		/// <value>Execution date of the trade</value>

		[JsonPropertyName("exDate")]
		public DateTime? ExDate { get; set; }

		/// <summary>
		/// Payment date of the trade
		/// </summary>
		/// <value>Payment date of the trade</value>

		[JsonPropertyName("paymentDate")]
		public DateTime? PaymentDate { get; set; }

		/// <summary>
		/// Record date of the trade
		/// </summary>
		/// <value>Record date of the trade</value>

		[JsonPropertyName("recordDate")]
		public DateTime? RecordDate { get; set; }

		/// <summary>
		/// Declared date of the trade
		/// </summary>
		/// <value>Declared date of the trade</value>

		[JsonPropertyName("declaredDate")]
		public DateTime? DeclaredDate { get; set; }

		/// <summary>
		/// Amount of the dividend
		/// </summary>
		/// <value>Amount of the dividend</value>

		[JsonPropertyName("amount")]
		public double? Amount { get; set; }

		/// <summary>
		/// Refers to the dividend income type<br/> - P = Partially qualified income<br/> - Q = Qualified income<br/> - N = Unqualified income<br/> - null = N/A or unknown 
		/// </summary>
		/// <value>Refers to the dividend income type<br/> - P = Partially qualified income<br/> - Q = Qualified income<br/> - N = Unqualified income<br/> - null = N/A or unknown </value>

		[JsonPropertyName("qualified")]
		public string Qualified { get; set; }

		/// <summary>
		/// Refers to the dividend flag, if set<br/> FI = Final dividend, div ends or instrument ends<br/> LI = Liquidation, instrument liquidates<br/> PR = Proceeds of a sale of rights or shares<br/> RE = Redemption of rights<br/> AC = Accrued dividend<br/> AR = Payment in arrears<br/> AD = Additional payment<br/> EX = Extra payment<br/> SP = Special dividend<br/> YE = Year end<br/> UR = Unknown rate<br/> SU = Regular dividend is suspended 
		/// </summary>
		/// <value>Refers to the dividend flag, if set<br/> FI = Final dividend, div ends or instrument ends<br/> LI = Liquidation, instrument liquidates<br/> PR = Proceeds of a sale of rights or shares<br/> RE = Redemption of rights<br/> AC = Accrued dividend<br/> AR = Payment in arrears<br/> AD = Additional payment<br/> EX = Extra payment<br/> SP = Special dividend<br/> YE = Year end<br/> UR = Unknown rate<br/> SU = Regular dividend is suspended </value>

		[JsonPropertyName("flag")]
		public string Flag { get; set; }
	}
}

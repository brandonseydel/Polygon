using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Split
	{
		/// <summary>
		/// Gets or Sets Ticker
		/// </summary>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Execution date of the split
		/// </summary>
		/// <value>Execution date of the split</value>

		[JsonPropertyName("exDate")]
		public DateTime? ExDate { get; set; }

		/// <summary>
		/// Payment date of the split
		/// </summary>
		/// <value>Payment date of the split</value>

		[JsonPropertyName("paymentDate")]
		public DateTime? PaymentDate { get; set; }

		/// <summary>
		/// Payment date of the split
		/// </summary>
		/// <value>Payment date of the split</value>

		[JsonPropertyName("recordDate")]
		public DateTime? RecordDate { get; set; }

		/// <summary>
		/// Payment date of the split
		/// </summary>
		/// <value>Payment date of the split</value>

		[JsonPropertyName("declaredDate")]
		public DateTime? DeclaredDate { get; set; }

		/// <summary>
		/// refers to the split ratio. The split ratio is an inverse of the number of shares that a holder of the stock would have after the split divided by the number of shares that the holder had before. <br/> For example: Split ratio of .5 = 2 for 1 split. 
		/// </summary>
		/// <value>refers to the split ratio. The split ratio is an inverse of the number of shares that a holder of the stock would have after the split divided by the number of shares that the holder had before. <br/> For example: Split ratio of .5 = 2 for 1 split. </value>

		[JsonPropertyName("ratio")]
		public double? Ratio { get; set; }

		/// <summary>
		/// To factor of the split. Used to calculate the split ratio forfactor/tofactor = ratio (eg ½ = 0.5) 
		/// </summary>
		/// <value>To factor of the split. Used to calculate the split ratio forfactor/tofactor = ratio (eg ½ = 0.5) </value>

		[JsonPropertyName("tofactor")]
		public int? Tofactor { get; set; }

		/// <summary>
		/// For factor of the split. Used to calculate the split ratio forfactor/tofactor = ratio (eg ½ = 0.5) 
		/// </summary>
		/// <value>For factor of the split. Used to calculate the split ratio forfactor/tofactor = ratio (eg ½ = 0.5) </value>

		[JsonPropertyName("forfactor")]
		public int? Forfactor { get; set; }

	}
}

using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class TickerData
	{
		/// <summary>
		/// Gets or Sets _Ticker
		/// </summary>

		[JsonPropertyName("ticker")]
		public string Ticker { get; set; }

		/// <summary>
		/// Name of the item.
		/// </summary>
		/// <value>Name of the item.</value>

		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// The market in which this ticker participates
		/// </summary>
		/// <value>The market in which this ticker participates</value>

		[JsonPropertyName("market")]
		public string Market { get; set; }

		/// <summary>
		/// Locale of where this ticker is traded
		/// </summary>
		/// <value>Locale of where this ticker is traded</value>

		[JsonPropertyName("locale")]
		public string Locale { get; set; }

		/// <summary>
		/// Currency this ticker is traded in
		/// </summary>
		/// <value>Currency this ticker is traded in</value>

		[JsonPropertyName("currency")]
		public string Currency { get; set; }

		/// <summary>
		/// If the ticker is active. False means the ticker has been delisted
		/// </summary>
		/// <value>If the ticker is active. False means the ticker has been delisted</value>

		[JsonPropertyName("active")]
		public bool? Active { get; set; }

		/// <summary>
		/// The listing exchange for this ticker
		/// </summary>
		/// <value>The listing exchange for this ticker</value>

		[JsonPropertyName("primaryExch")]
		public string PrimaryExch { get; set; }

		/// <summary>
		/// URL of this ticker. Use this to get more information about the ticker.
		/// </summary>
		/// <value>URL of this ticker. Use this to get more information about the ticker.</value>

		[JsonPropertyName("url")]
		public string Url { get; set; }

		/// <summary>
		/// Last time this ticker record was updated.
		/// </summary>
		/// <value>Last time this ticker record was updated.</value>

		[JsonPropertyName("updated")]
		public DateTime? Updated { get; set; }

		/// <summary>
		/// Additional details about this ticker. No schema.
		/// </summary>
		/// <value>Additional details about this ticker. No schema.</value>

		[JsonPropertyName("attrs")]
		public object Attrs { get; set; }

		/// <summary>
		/// Gets or Sets Codes
		/// </summary>

		[JsonPropertyName("codes")]
		public TickerCodes Codes { get; set; }

	}
}

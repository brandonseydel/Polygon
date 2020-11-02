using System;
using System.Text.Json.Serialization;


namespace Polygon.Models
{

	public class Symbol
	{
		/// <summary>
		/// Gets or Sets _Symbol
		/// </summary>

		[JsonPropertyName("symbol")]
		public string Ticker { get; set; }

		/// <summary>
		/// Name of the item.
		/// </summary>
		/// <value>Name of the item.</value>

		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Type of symbol this is. See symbol types.
		/// </summary>
		/// <value>Type of symbol this is. See symbol types.</value>

		[JsonPropertyName("type")]
		public string Type { get; set; }

		/// <summary>
		/// URL of this symbol. Use this to get this symbols endpoints.
		/// </summary>
		/// <value>URL of this symbol. Use this to get this symbols endpoints.</value>

		[JsonPropertyName("url")]
		public string Url { get; set; }

		/// <summary>
		/// Last time this company record was updated.
		/// </summary>
		/// <value>Last time this company record was updated.</value>

		[JsonPropertyName("updated")]
		public DateTime? Updated { get; set; }

		/// <summary>
		/// If the symbol is listed on the OTC Markets.
		/// </summary>
		/// <value>If the symbol is listed on the OTC Markets.</value>

		[JsonPropertyName("isOTC")]
		public bool? IsOTC { get; set; }

	}
}

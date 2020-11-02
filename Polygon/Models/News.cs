using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class News
	{
		/// <summary>
		/// Gets or Sets Symbols
		/// </summary>

		[JsonPropertyName("symbols")]
		public List<string> Symbols { get; set; }

		/// <summary>
		/// Name of the article
		/// </summary>
		/// <value>Name of the article</value>

		[JsonPropertyName("title")]
		public string Title { get; set; }

		/// <summary>
		/// URL of this article
		/// </summary>
		/// <value>URL of this article</value>

		[JsonPropertyName("url")]
		public string Url { get; set; }

		/// <summary>
		/// Source of this article
		/// </summary>
		/// <value>Source of this article</value>

		[JsonPropertyName("source")]
		public string Source { get; set; }

		/// <summary>
		/// Short summary of the article
		/// </summary>
		/// <value>Short summary of the article</value>

		[JsonPropertyName("summary")]
		public string Summary { get; set; }

		/// <summary>
		/// URL of the image for this article, if found
		/// </summary>
		/// <value>URL of the image for this article, if found</value>

		[JsonPropertyName("image")]
		public string Image { get; set; }

		/// <summary>
		/// Timestamp of the article
		/// </summary>
		/// <value>Timestamp of the article</value>

		[JsonPropertyName("timestamp")]
		public DateTime? Timestamp { get; set; }

		/// <summary>
		/// Gets or Sets Keywords
		/// </summary>

		[JsonPropertyName("keywords")]
		public List<string> Keywords { get; set; }
	}
}

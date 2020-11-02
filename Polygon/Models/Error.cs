using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Error
	{
		/// <summary>
		/// Gets or Sets Code
		/// </summary>

		[JsonPropertyName("code")]
		public int? Code { get; set; }

		/// <summary>
		/// Gets or Sets Message
		/// </summary>

		[JsonPropertyName("message")]
		public string Message { get; set; }

		/// <summary>
		/// Gets or Sets Fields
		/// </summary>

		[JsonPropertyName("fields")]
		public string Fields { get; set; }
	}
}

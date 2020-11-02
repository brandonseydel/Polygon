using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class NotFound
	{
		/// <summary>
		/// Gets or Sets Message
		/// </summary>

		[JsonPropertyName("message")]
		public string Message { get; set; }
	}
}

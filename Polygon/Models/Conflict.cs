using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Conflict
	{
		/// <summary>
		/// Gets or Sets Message
		/// </summary>

		[JsonPropertyName("message")]
		public string Message { get; set; }


		/// <summary>
		/// Get the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
	}
}

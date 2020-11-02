using System.Text.Json.Serialization;

namespace Polygon.Models
{
	public class ReferenceTypesGetResponse
	{
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets Results
		/// </summary>
		[JsonPropertyName("results")]
		public object Results { get; set; }


	}
}

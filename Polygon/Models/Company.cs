using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class Company
	{
		/// <summary>
		/// URL of the entities logo.
		/// </summary>
		/// <value>URL of the entities logo.</value>

		[JsonPropertyName("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// Symbols primary exchange
		/// </summary>
		/// <value>Symbols primary exchange</value>

		[JsonPropertyName("exchange")]
		public string Exchange { get; set; }

		/// <summary>
		/// Name of the company/entity
		/// </summary>
		/// <value>Name of the company/entity</value>

		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Symbol
		/// </summary>

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// Date this symbol was listed on the exchange.
		/// </summary>
		/// <value>Date this symbol was listed on the exchange.</value>

		[JsonPropertyName("listdate")]
		public DateTime? Listdate { get; set; }

		/// <summary>
		/// Official CIK guid used for SEC database / filings.
		/// </summary>
		/// <value>Official CIK guid used for SEC database / filings.</value>

		[JsonPropertyName("cik")]
		public string Cik { get; set; }

		/// <summary>
		/// Bloomberg guid for this symbol
		/// </summary>
		/// <value>Bloomberg guid for this symbol</value>

		[JsonPropertyName("bloomberg")]
		public string Bloomberg { get; set; }

		/// <summary>
		/// guid for the OpenFigi project ( https://openfigi.com/ )
		/// </summary>
		/// <value>guid for the OpenFigi project ( https://openfigi.com/ )</value>

		[JsonPropertyName("figi")]
		public string Figi { get; set; }

		/// <summary>
		/// Legal Entity Identifier (LEI) guid for symbol ( https://en.wikipedia.org/wiki/Legal_Entity_Identifier )
		/// </summary>
		/// <value>Legal Entity Identifier (LEI) guid for symbol ( https://en.wikipedia.org/wiki/Legal_Entity_Identifier )</value>

		[JsonPropertyName("lei")]
		public string Lei { get; set; }

		/// <summary>
		/// Standard Industrial Classification (SIC) id for symbol ( https://en.wikipedia.org/wiki/Standard_Industrial_Classification )
		/// </summary>
		/// <value>Standard Industrial Classification (SIC) id for symbol ( https://en.wikipedia.org/wiki/Standard_Industrial_Classification )</value>

		[JsonPropertyName("sic")]
		public int? Sic { get; set; }

		/// <summary>
		/// Country in which this company is registered
		/// </summary>
		/// <value>Country in which this company is registered</value>

		[JsonPropertyName("country")]
		public string Country { get; set; }

		/// <summary>
		/// Industry this company operates in
		/// </summary>
		/// <value>Industry this company operates in</value>

		[JsonPropertyName("industry")]
		public string Industry { get; set; }

		/// <summary>
		/// Sector of the indsutry in which this symbol operates in
		/// </summary>
		/// <value>Sector of the indsutry in which this symbol operates in</value>

		[JsonPropertyName("sector")]
		public string Sector { get; set; }

		/// <summary>
		/// Current market cap for this company
		/// </summary>
		/// <value>Current market cap for this company</value>

		[JsonPropertyName("marketcap")]
		public int? Marketcap { get; set; }

		/// <summary>
		/// Approximate number of employees
		/// </summary>
		/// <value>Approximate number of employees</value>

		[JsonPropertyName("employees")]
		public int? Employees { get; set; }

		/// <summary>
		/// Phone number for this company. Usually corporate contact number.
		/// </summary>
		/// <value>Phone number for this company. Usually corporate contact number.</value>

		[JsonPropertyName("phone")]
		public string Phone { get; set; }

		/// <summary>
		/// Name of the companies current CEO
		/// </summary>
		/// <value>Name of the companies current CEO</value>

		[JsonPropertyName("ceo")]
		public string Ceo { get; set; }

		/// <summary>
		/// URL of the companies website
		/// </summary>
		/// <value>URL of the companies website</value>

		[JsonPropertyName("url")]
		public string Url { get; set; }

		/// <summary>
		/// A description of the company and what they do/offer
		/// </summary>
		/// <value>A description of the company and what they do/offer</value>

		[JsonPropertyName("description")]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets Similar
		/// </summary>

		[JsonPropertyName("similar")]
		public List<string> Similar { get; set; }

		/// <summary>
		/// Gets or Sets Tags
		/// </summary>

		[JsonPropertyName("tags")]
		public List<string> Tags { get; set; }

		/// <summary>
		/// Last time this company record was updated.
		/// </summary>
		/// <value>Last time this company record was updated.</value>

		[JsonPropertyName("updated")]
		public DateTime? Updated { get; set; }

	}
}

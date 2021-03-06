﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Polygon.Models
{
	public class HistoricForexFromToDateGetResponse
	{
		/// <summary>
		/// Date that was evaluated from the request
		/// </summary>
		/// <value>Date that was evaluated from the request</value>

		[JsonPropertyName("day")]
		public DateTime? Day { get; set; }

		/// <summary>
		/// Map for shortened result keys
		/// </summary>
		/// <value>Map for shortened result keys</value>

		[JsonPropertyName("map")]
		public object Map { get; set; }

		/// <summary>
		/// Milliseconds of latency for the query results
		/// </summary>
		/// <value>Milliseconds of latency for the query results</value>

		[JsonPropertyName("msLatency")]
		public int? MsLatency { get; set; }

		/// <summary>
		/// Status of this requests response
		/// </summary>
		/// <value>Status of this requests response</value>

		[JsonPropertyName("status")]
		public string Status { get; set; }

		/// <summary>
		/// Currency Pair that was evaluated from the request
		/// </summary>
		/// <value>Currency Pair that was evaluated from the request</value>

		[JsonPropertyName("pair")]
		public string Pair { get; set; }

		/// <summary>
		/// Gets or Sets Ticks
		/// </summary>

		[JsonPropertyName("ticks")]
		public List<Forex> Ticks { get; set; }
	}
}

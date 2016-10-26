using System;
using Refit;
using Newtonsoft.Json;
namespace TestHackathon.BL
{
	public class Place
	{
		public Place()
		{
		}
		[JsonProperty(PropertyName = "place name")]
		public string PlaceName { get; set; }

		[JsonProperty(PropertyName = "longitude")]
		public string Lon { get; set;}

		[JsonProperty(PropertyName = "state")]
		public string State { get; set; }

		[JsonProperty(PropertyName = "state abbreviation")]
		public string StateCode { get; set; }

		[JsonProperty(PropertyName = "latitude")]
		public string Lat { get; set;}

	}

}

using System;
using Refit;
using Newtonsoft.Json;
using TestHackathon.BL.Base;
using SQLite; 
namespace TestHackathon.BL
{
	public class Place : IBusinessEntity
	{
		public Place()
		{
		}

		[PrimaryKey, NotNull, AutoIncrement]
		public int ID { get; set; }

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

		public string PostCode { get; set;}

	}

}

using System;
using System.Collections.Generic;
using TestHackathon.BL.Base;
using Refit;
using SQLite;
using Newtonsoft.Json;
namespace TestHackathon.BL
{
	public class Zip : IBusinessEntity
	{
		public Zip()
		{
		}

        [PrimaryKey, NotNull, AutoIncrement]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "post code")]
		public string PostCode { get; set; }

		[JsonProperty(PropertyName = "country")]
		public string Country { get; set;}

		[JsonProperty(PropertyName = "country abbreviation")]
		public string CountryCode { get; set; }

		//[JsonProperty(PropertyName = "places")]
		//public List<Place> PlaceList { get; set;}

	}
}

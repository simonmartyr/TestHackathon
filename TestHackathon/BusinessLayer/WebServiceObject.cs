using System;
using TestHackathon.BL;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace TestHackathon.BL
{
	public class WebServiceObject : Zip
	{
		public WebServiceObject()
		{
		}

		[JsonProperty(PropertyName = "places")]
		public List<Place> PlaceList { get; set; }
	}
}

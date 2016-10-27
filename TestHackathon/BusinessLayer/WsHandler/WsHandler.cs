using System;
using Refit;
using Newtonsoft.Json; 
using System.Threading.Tasks;

namespace TestHackathon.BL.WsHandler
{
	public class RefitConstants
	{
		//90210
		public static readonly string BASE_URL = "http://api.zippopotam.us/us"; 
	}



	public interface GetUsAddress
	{
		[Get("/{postcode}")]
		Task<WebServiceObject> getZipData([AliasAs ("postcode")] string postcode); 
	}


}

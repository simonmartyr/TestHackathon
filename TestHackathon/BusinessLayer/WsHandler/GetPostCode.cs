using System;
using Refit;
using System.Collections.Generic;
using System.Linq;
namespace TestHackathon.BL.WsHandler
{
	public class GetPostCode
	{
		public GetPostCode()
		{
		}

		public async void getZip()
		{
			var rest = RestService.For<GetUsAddress>(BL.WsHandler.RefitConstants.BASE_URL);
			try
			{
				WebServiceObject result = await rest.getZipData("90210");
				Console.WriteLine(result.PostCode);
				//Zip zip = result as Zip;
				List<Place> places = result.PlaceList; 
                SaveZip(result);
			}
			catch (Exception e)
			{
				Console.WriteLine(e); 
			}

		}

		private void SaveZip(WebServiceObject result)
        {
			Zip zip = new Zip
			{
				PostCode = result.PostCode,
				Country = result.Country,
				CountryCode = result.CountryCode
			}

            BL.Mangers.ZipManager.SaveZip(zip);

			foreach (Place i in result.PlaceList)
			{
				i.PostCode = zip.PostCode;

			}
        }


	}
}

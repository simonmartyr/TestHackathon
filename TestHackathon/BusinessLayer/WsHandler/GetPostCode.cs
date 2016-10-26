using System;
using Refit;
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
				var result = await rest.getZipData();
				Console.WriteLine(result.PostCode);
                SaveZip(result);
			}
			catch (Exception e)
			{
				Console.WriteLine(e); 
			}

		}

        private void SaveZip(Zip zip)
        {
            BL.Mangers.ZipManager.SaveZip(zip);
        }


	}
}

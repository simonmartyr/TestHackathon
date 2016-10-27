using System;
using System.Collections.Generic;
using System.Linq;
namespace TestHackathon.BL.Mangers
{
	public static class PlaceManger
	{
		static PlaceManger()
		{
		}

		public static Place GetPlaceItem(int id)
		{
			return DAL.DataManager.GetPlace(id); 
		}

		public static List<Place> GetPlaceItems()
		{
			try
			{
				return DAL.DataManager.GetPlaces().ToList();
			}
			catch (Exception e)
			{
				Console.WriteLine(e); 
				return null; 
			}

		}
		public static int SavePlace(Place place)
		{
			return DAL.DataManager.SavePlace(place); 
		}

		public static int DeleteZip(int i)
		{
			return DAL.DataManager.DeleteZip(i); 
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestHackathon.BL.Mangers
{
    public static class ZipManager
    {
        static ZipManager()
        {

        }
        public static Zip GetZipItem(int id)
        {
            return DAL.DataManager.GetZip(id); 
        }
        public static List<Zip> GetZipItems()
        {
            try
            {
                return DAL.DataManager.GetZips().ToList();
            }
            catch(Exception e)
            {
                Console.Write(e);
                return null; 
            }
        }
        public static int SaveZip(Zip zip)
        {
            return DAL.DataManager.SaveZip(zip); 
        }
        public static int DeleteZip(int i)
        {
            return DAL.DataManager.DeleteZip(i); 
        }
    }
}

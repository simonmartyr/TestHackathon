using System;
using System.Collections.Generic;
using System.Text;

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




    }
}

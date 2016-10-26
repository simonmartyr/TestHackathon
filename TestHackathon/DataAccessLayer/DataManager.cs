using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestHackathon.BL; 


namespace TestHackathon.DAL
{
    public class DataManager
    {
        DataLayer.DataBase db = null;
        protected static string dbLocation;
        protected static DataManager me; 

        static DataManager()
        {
            me = new DataManager(); 
        }

        protected DataManager()
        {
            dbLocation = databaseFilePath;
            db = new TestHackathon.DataLayer.DataBase(dbLocation); 
        }

        public static string databaseFilePath
        {
            get
            {
                var sqliteFilename = "HypothekerDB.db3";
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
                string libraryPath = Path.Combine(documentsPath, "../Library/"); // Library folder
                var path = Path.Combine(libraryPath, sqliteFilename);
                return path; 
            }
        }

        public static Zip GetZip(int id)
        {
            return me.db.GetItem<Zip>(id); 
        }

        public static IEnumerable<Zip> GetZips()
        {
            return me.db.GetItems<Zip>(); 
        }

        public static int SaveZip(Zip item)
        {
            return me.db.SaveItem<Zip>(item);
        }

        public static int DeleteZip(int id)
        {
            return me.db.DeleteItem<Zip>(id);
        }

        public static void ClearZips()
        {
            me.db.ClearTable<Zip>(); 
        }



    }
}
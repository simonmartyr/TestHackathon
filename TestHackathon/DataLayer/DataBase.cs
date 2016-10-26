using System;
using System.Collections.Generic;
using TestHackathon.BL; 
using System.Linq;
using System.Text;
using SQLite; 

namespace TestHackathon.DataLayer
{
    public class DataBase : SQLiteConnection
    {
        static object locker = new object();

        public DataBase(string path) : base(path)
        {
            CreateTable<Zip>(); 
        }

        public void ClearTable<T>() where T : BL.Base.IBusinessEntity
        {
            lock (locker)
            {
                ClearTable<T>(); 
            }
        }

        public int CountTable<T>() where T: BL.Base.IBusinessEntity
        {
            return CountTable<T>(); 
        }

        public IEnumerable<T> GetItems<T>() where T : BL.Base.IBusinessEntity, new()
        {
            lock (locker)
            {
                return (from i in Table<T>() select i).ToList(); 
            }
        }

        public T GetItem<T>(int id) where T : BL.Base.IBusinessEntity, new()
        {
            lock (locker)
            {
                return Table<T>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem<T>(T item) where T : BL.Base.IBusinessEntity
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    Update(item);
                    return item.ID;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int DeleteItem<T>(int id) where T : BL.Base.IBusinessEntity, new()
        {
            lock (locker)
            {
                return Delete(new T() { ID = id });
            }
        }


    }
}
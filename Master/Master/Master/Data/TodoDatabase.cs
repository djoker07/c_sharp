using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Master
{
    public class TodoDatabase
    {

        static object locker = new object();

        SQLiteConnection database;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
        /// if the database doesn't exist, it will create the database and all the tables.
        /// </summary>
        /// <param name='path'>
        /// Path.
        /// </param>
        public TodoDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<TODOItem>();
            database.CreateTable<EventItem>();
        }

        public IEnumerable<TODOItem> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<TODOItem>() select i).ToList();
            }
        }  

        public IEnumerable<TODOItem> GetItemsNotDone()
        {
            lock (locker)
            {
                return database.Query<TODOItem>("SELECT * FROM [TODOItem] WHERE [Done] = 0");
            }
        }

        public TODOItem GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<TODOItem>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem(TODOItem item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public void DeleteItem(int id)
        {
            lock (locker)
            {
                //return database.Delete<TODOItem>(id);
                 database.Query<TODOItem>("DELETE FROM [TODOItem] WHERE [ID] = " + id);
            }
        }


        //events table methods --------------------------------------------------


        public IEnumerable<EventItem> GetEventItems()
        {
            lock (locker)
            {
                return (from i in database.Table<EventItem>() select i).ToList();
            }
        }

        public EventItem GetEventItem(int id)
        {
            lock (locker)
            {
                return database.Table<EventItem>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveEventItem(EventItem item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public void DeleteEventItem(int id)
        {
            lock (locker)
            {
                //return database.Delete<TODOItem>(id);
                database.Query<EventItem>("DELETE FROM [EventItem] WHERE [ID] = " + id);
            }
        }
    }
}

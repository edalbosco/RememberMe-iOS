using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using SQLite.Net;
using RememberMe.Models;

namespace RememberMe.Data
{
    public class ItemDatabase
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
        public ItemDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            database.CreateTable<Item>();
        }
        
        public IEnumerable<Item> GetItems(string search = null)
        {

            string query = "SELECT * FROM [Item]";

            if (!string.IsNullOrEmpty(search))
            {
                query += " WHERE Name like '%" + search + "%'";
            }

            lock (locker)
            {
                return database.Query<Item>(query);
            }
        }

        public IEnumerable<Reminder> GetReminders()
        {
            lock (locker)
            {
                return database.Table<Reminder>().ToList();
            }
        }

        public Item GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<Item>().FirstOrDefault(x => x.ID == id);
            }
        }

        public Reminder GetReminder(int id)
        {
            lock (locker)
            {
                return database.Table<Reminder>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem(Item item)
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

        public int SaveReminder(Reminder reminder)
        {
            lock (locker)
            {
                if (reminder.ID != 0)
                {
                    database.Update(reminder);
                    return reminder.ID;
                }
                else
                {
                    return database.Insert(reminder);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Item>(id);
            }
        }

        public int DeleteReminder(int id)
        {
            lock (locker)
            {
                return database.Delete<Reminder>(id);
            }
        }
    }
}


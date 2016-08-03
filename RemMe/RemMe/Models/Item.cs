using System;
using SQLite;
using SQLite.Net.Attributes;

namespace RememberMe.Models
{
	public class Item
	{
		public Item ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Place { get; set; }
        
        [Ignore]
        public string NamePlace
        {
            get
            {
                return "Your " + Name + " is " + Place;
            }
        }
    }
}


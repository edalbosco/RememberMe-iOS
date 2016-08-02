using System;
using SQLite;
using SQLite.Net.Attributes;

namespace RemMe.Models
{
	public class Item
	{
		public Item ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
	}
}


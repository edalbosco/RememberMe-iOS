using System;
using SQLite;
using SQLite.Net.Attributes;

namespace RememberMe.Models
{
	public class Reminder
	{
		public Reminder()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Time { get; set; }
    }
}


using System;
using SQLite;
using SQLite.Net;

namespace RemMe.Data
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}


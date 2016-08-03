using System;
using SQLite;
using SQLite.Net;

namespace RememberMe.Data
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}


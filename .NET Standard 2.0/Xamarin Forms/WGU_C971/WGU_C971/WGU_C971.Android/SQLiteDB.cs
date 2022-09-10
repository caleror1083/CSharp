/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using SQLite;
using System.IO;
using WGU_C971.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]

namespace WGU_C971.Droid
	{
		public class SQLiteDB : ISQLiteDB
			{
				public SQLiteAsyncConnection GetConnection()
					{
						var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
						var path = Path.Combine(documentsPath, "MySQLite.db3");
						return new SQLiteAsyncConnection(path);
					}
			}
	}
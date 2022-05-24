/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using SQLite;

namespace WGU_C971
	{
		public interface ISQLiteDB
			{
				SQLiteAsyncConnection GetConnection();
			}
	}
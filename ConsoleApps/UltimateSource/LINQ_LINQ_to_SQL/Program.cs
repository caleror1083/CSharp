﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_LINQ_to_SQL
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataClasses1DataContext db = new DataClasses1DataContext();

			var dtm = db.Mapping;

			foreach(var t in dtm.GetTables())
				{
					Console.WriteLine(t.TableName);
				}
		}
	}
}

﻿using System.Windows.Forms;

namespace Calendar
	{
		static class Program
			{
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new MainForm());
					}
			}
	}
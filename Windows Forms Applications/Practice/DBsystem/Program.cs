﻿using System.Windows.Forms;

namespace DBsystem
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
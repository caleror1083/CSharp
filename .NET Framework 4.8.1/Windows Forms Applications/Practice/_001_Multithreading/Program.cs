﻿using System.Windows.Forms;

namespace _001_Multithreading
	{
		internal static class Program
			{
				static void Main()
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new MainForm());
					}
			}
	}
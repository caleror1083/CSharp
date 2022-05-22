/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Windows.Forms;

namespace WGU_C969
	{
		class ApptExceptions : ApplicationException
			{
				public void OutsideHours()
					{
						MessageBox.Show("Error! This appointment is outside business hours!");
					}

				public void Overlapping()
					{
						MessageBox.Show("Error! This appointment is overlapping another appointment!");
					}
			}
	}
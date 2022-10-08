using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _051_DatabaseFirstEFCore
	{
		internal class Program
			{
				static void Main(string[] args)
					{
						Examples myExamples = new Examples();
						myExamples.ProcessExamples();
					}
			}
	}
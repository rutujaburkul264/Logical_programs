using System;
using System.Threading;//to perform multiple operations
using System.Diagnostics;//to use stopwatch feature

namespace LogicalPrograms
{
	class Stopwatch
	{
		public static void StopWatch()
		{
			System.Diagnostics.Stopwatch stopw = new System.Diagnostics.Stopwatch();
			stopw.Start();
			for (int i = 0; i < 100; i++)
			{
				Thread.Sleep(2);
			}
			stopw.Stop();
			Console.WriteLine(" Time elapsed: {0} ", stopw.Elapsed);
		}
	}
	
}

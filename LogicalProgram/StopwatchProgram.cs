using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class StopwatchProgram
    {
        public void StopWatch()
        {
            var watch = Stopwatch.StartNew();

            for (var i = 0; i < 2; i++)
            {
                using (var task = Task.Delay(1000))
                {
                    task.Wait();
                }

                watch.Stop();

                using (var task = Task.Delay(1000))
                {
                    task.Wait();
                }

                watch.Start();
            }

            watch.Stop();

            Console.WriteLine("Time elapsed: " + watch.Elapsed);
        }
    }
}

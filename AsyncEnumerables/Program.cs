/*
 * Starting with C# 8.0, you can create and consume streams asynchronously. 
 * A method that returns an asynchronous stream has three properties:
 */

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncEnumerables
{
    class Program
    {
        public static IEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 5; i++)
            {
                LongRunningOperation();
                yield return i;
            }
        }

        static void Main()
        {
            foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

        private static void LongRunningOperation()
        {
            Thread.Sleep(2000);
        }

        private static async Task LongRunningOperationAsync()
        {
            await Task.Delay(2000);
        }

    }
}

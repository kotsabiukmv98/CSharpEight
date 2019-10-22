/*
 * Starting with C# 8.0, you can create and consume streams asynchronously. 
 * A method that returns an asynchronous stream has three properties:
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpEight
{
    public class AsyncEnumerables
    {
        public static async Task Demo()
        {
            //foreach (var number in GenerateSequence())
            //{
            //    Console.WriteLine(number);
            //}

            await foreach (var number in GenerateSequenceAsync())
            {
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                //await Task.Delay(100); // Some long running operation. Can't use 'await' here
                yield return i;
            }
        }

        public static async IAsyncEnumerable<int> GenerateSequenceAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}

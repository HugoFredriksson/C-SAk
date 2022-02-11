using System;
using System.Diagnostics;
using System.Threading;
 

namespace ugh
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Random arr = new Random();
        int[] intArr = new int[2000];

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        for (int i = 0; i < intArr.Length; i++)
        {
            int num = arr.Next(1, 1000);
            intArr[i] = num;
            int temp;
                for (int j = 0; j <= intArr.Length - 2; j++) {
                for (int x = 0; x <= intArr.Length - 2; x++) {
                    if (intArr[x] > intArr[x + 1]) {
                        temp= intArr[x + 1];
                        intArr[x + 1] = intArr[x];
                        intArr[x] = temp;
               }
               
            }
         }
        }
        stopwatch.Stop();
        Console.WriteLine("Här är de sorterade:");
        foreach (int p in intArr)
            Console.Write(p + " ");
        Console.Read();
        Console.WriteLine("Tiden: {0} ms", stopwatch.ElapsedMilliseconds);
        


        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace yuh
{
    class Program
    {
        static void Main(string[] args)
        {

        List<int> intList = new List<int>(); 

        Random arr = new Random();

        Stopwatch watch = new Stopwatch();

        for(int i = 0; intList.Count < 1000; i++){
                intList.Add(arr.Next(1, 1001));
            }

        watch.Start();
            for(int i = 0; i < intList.Count- 1; i++){
                for(int j = 0; j < intList.Count -1; j++){
                    if(intList[j] > intList[j+1]){
                        int a = intList[j];
                        intList[j] = intList[j + 1];
                        intList[j+1] = a;
                    }
                }
            }
            watch.Stop();
    
            foreach(int i in intList){
                Console.WriteLine(i);
            }

            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        foreach (int i in intList)
            Console.Write(i +" ");
        Console.Read();
        Console.WriteLine("Tiden: {0} ms", watch.ElapsedMilliseconds);
        


        }
    }
    
}

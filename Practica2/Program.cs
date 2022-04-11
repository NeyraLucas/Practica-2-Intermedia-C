using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Practica2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///#1
            ///Tuple

            dynamic tupleList = new List<Tuple<int, int>>();

            tupleList.Add(Tuple.Create(1, 2));
            tupleList.Add(Tuple.Create(3, 4));

            List<(string Name, string Kind, int Replicas, bool Run)> tupleList2 = new List<(string Name, string Kind, int Replicas, bool Run)>();


            tupleList2.Add(("Vero", "Noc", 5, true));
            tupleList2.Add(("Luis", "Noc", 7, false));

            foreach (var tuple in tupleList)
            {
                Console.WriteLine($"Tuple 1: ${tuple}");
            }

            foreach (var tuple in tupleList2)
            {
                Console.WriteLine($"Tuple 2: ${tuple}");
            }

            ///#2
            ///Operador implicito
            ///
           /* Bird colibri = new Bird("Colibri", "Green");
            Maths suma = new Maths("1", "4");

            Maths testBird = colibri;
           */
            // Console.WriteLine($"Colibri: {testBird.numberY}  {testBird.numberX}");

            ///#3
            ///Tipos por valor y referencia
            ///
            ExampleStruct[] exStruct = new ExampleStruct[1000000];
            ExampleClass[] exClass = new ExampleClass[1000000];

            //Stopwatch
            var timerClass = new Stopwatch();
            timerClass.Start();
            for (int i = 0; i < 1000000; i++)
            {
                exClass[i] = new ExampleClass(1, 2);
            }
            timerClass.Stop();
            TimeSpan time = timerClass.Elapsed;

            //Stop struct
            var timerStruct = new Stopwatch();
            timerStruct.Start();
            for (int i = 0; i < 1000000; i++)
            {
                exStruct[i] = new ExampleStruct(2, 3);
            }
            timerStruct.Stop();
            TimeSpan time2 = timerStruct.Elapsed;
            Console.WriteLine($"Class: {time.ToString(@"m\:ss\.fff")}  Struct: {time2.ToString(@"m\:ss\.fff")}");

            ///#4.1
            ///Colas,List,Diccionarios
            ///
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };  
            Queue<int> numbersReverse = new Queue<int>();

            foreach (int num in arr.Reverse())
            {
                numbersReverse.Enqueue(num);
            }

            Console.WriteLine("Array Original");
            foreach (int item in arr)
            {
                Console.WriteLine($" [{item}], ");
            }

            foreach (int item in numbersReverse)
            {
                Console.WriteLine($"Queue: {item}");
            }

            ///4.1
            ///Metodo
            ///
            QueueListDictionary queueExample = new QueueListDictionary();
            //Init Stopwatch 4.1
            var timerQueue = new Stopwatch();
            timerQueue.Start();
            dynamic reverseQueue = queueExample.ReverseWithQueue(arr);
            timerQueue.Stop();
            //END
            TimeSpan timerQueueResult = timerQueue.Elapsed;
            Console.WriteLine($"Time queue: {timerQueueResult.ToString(@"m\:ss\.fff")}");

            foreach (int item in reverseQueue)
            {
                Console.WriteLine($"Queue2: {item}");
            }

            ///4.2
            ///ReverseWithList
            ///

            //Init Stopwatch 4.2
            var timerList = new Stopwatch();
            timerList.Start();
            dynamic reverseList = queueExample.ReverseWithList(arr);
            //END
            timerList.Stop();
            TimeSpan timerListResult = timerList.Elapsed;
            Console.WriteLine($"Time List: {timerListResult.ToString(@"m\:ss\.fff")}");
            foreach (int item in reverseList)
            {
                Console.WriteLine($"List: {item}");
            }

            ///4.3
            ///Dictionary
            ///

            //Init Stopwatch 4.3
            var timerDict = new Stopwatch();
            timerDict.Start();
            dynamic reverseDictionary = queueExample.ReverseWithDict(arr);
            //END
            timerDict.Stop();
            TimeSpan timerDictResult = timerDict.Elapsed;
            Console.WriteLine($"Time Dict: {timerDictResult.ToString(@"m\:ss\.fff")}");
            
            foreach (KeyValuePair<int,int> item in reverseDictionary)
            {
                Console.WriteLine($"Dictionary Key: {item.Key}  Value: {item.Value}");
            }

            ///5
            ///Stack
            ///
            QueueListDictionary palindromo = new QueueListDictionary();
            var examplePalindromo = palindromo.Palindromo("Otto");
            Console.WriteLine($"Palindromo: {examplePalindromo}");

        }


        public void ReturnClassA(Bird b)
        {
            Console.WriteLine($"Class Bird: {b.name}  {b.color}");
        }

        public void ReturnClassB(Maths m)
        {
            Console.WriteLine($"Class Bird: {m.numberX}  {m.numberY}");
        }

    }
}
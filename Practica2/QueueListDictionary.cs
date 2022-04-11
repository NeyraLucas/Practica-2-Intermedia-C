using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class QueueListDictionary
    {
        public QueueListDictionary() { }

        public Queue<int> ReverseWithQueue(int[] arr)
        {
            Queue<int> enterosQueue = new Queue<int>();
            
            foreach (int num in arr.Reverse())
            {
                enterosQueue.Enqueue(num);
            }
            return enterosQueue;
        }

        public List<int> ReverseWithList(int [] arr)
        {
            List<int> enterosList = new List<int>();

            foreach (int num in arr.Reverse())
            {
                enterosList.Add(num);
            }

            return enterosList;
        }

        public Dictionary<int,int> ReverseWithDict(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int num in arr.Reverse())
            {
                dict.Add(num,num);
            }

            return dict;
        }

        ///Palindromo
        ///ana -> ana
        ///
        public bool Palindromo(string args)
        {

            //init
            Stack<char> verificar = new Stack<char>();
            args = args.ToLower();

            foreach(char str in args)
            {
                verificar.Push(str);
            }

            if(args.Length == verificar.Count)
            {
                foreach(int item in args)
                {
                    if (item == verificar.Pop())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }


           return false; 
        } 

    }
}

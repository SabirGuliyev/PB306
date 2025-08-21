using System.Collections;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ArrayList
            //ArrayList array = new ArrayList();
            //array.Add(5);
            //array.Add("salam");
            //array.Add('A');

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedList
            //SortedList sorted=new SortedList();
            //sorted.Add(3,"Nasib");
            //sorted.Add("Salam","Nasib");
            //sorted.Add(true,"Nasib");




            //Add() O(n)   ContainsKey O(log N)  Index destekleyir
            //SortedList<string, string> pairs = new();
            //pairs.Add("c2", "Nasib");
            //pairs.Add("c7", "Vuqar");
            //pairs.Add("1a", "Konul");
            //pairs.Add("a1", "Kutais");
            //pairs.Add("a1","Kutais");
            //pairs.ContainsKey(5);  
            //Console.WriteLine(pairs.TryAdd(1, "Kutais"));

            //Console.WriteLine(pairs["c7"]); ;


            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine(pair.Key + " " + pair.Value);
            //}

            #endregion

            #region Stack & Queue
            //LIFO  O(1)
            //Stack<string> stack=new ();

            //stack.Push("Oslo");
            //stack.Push("Lenkeran");
            //stack.Push("London");
            //stack.Push("Berde");
            //stack.Push("Mingecevir");

            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //string str;
            //stack.TryPop(out str);


            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("---------------------");

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //FIFO O(1)
            //Queue<string> collection=new Queue<string>();
            //collection.Enqueue("Vuqar");
            //collection.Enqueue("Shabnam");
            //collection.Enqueue("Raul");
            //collection.Enqueue("Fidan");

            //collection.Peek();
            //Console.WriteLine(collection.TryDequeue());
            //Console.WriteLine(collection.Dequeue());
            //Console.WriteLine(collection.Dequeue());
            //Console.WriteLine(collection.Dequeue());
            //Console.WriteLine(collection.Dequeue());
            //Console.WriteLine("-------------------");


            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            //Searching O(1) Index desteklemir

            //Dictionary<int, string> dictionary = new();

            //dictionary.Add(4, "Vuqar");
            //dictionary.Add(7, "ZulVuqar");
            //dictionary.Add(1, "Eynulla");

            //Console.WriteLine(dictionary[7]);

            ////foreach (var item in dictionary)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            #endregion
        }
    }
}

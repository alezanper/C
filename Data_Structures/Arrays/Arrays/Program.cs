using System;
using System.Collections.Generic;

namespace Arrays {
    class Program {
        static void Main(string[] args) {

            /**
             * Using Arrays
             */
            String[] mArray = new String[] {
                "Item1", "Item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10"};
            Console.WriteLine("Item at index 2 is: " + mArray[2]);
            Console.WriteLine();
            Console.WriteLine("This is the content of the array:");

            foreach (String item in mArray)
                Console.WriteLine(item);
            Console.WriteLine();

            /**
             * Using Stack
             * First In Last Out FILO
             */
            Stack<String> mStack = new Stack<String>();
            mStack.Push("item1");
            mStack.Push("item2");
            mStack.Push("item3");
            mStack.Push("item4");
            mStack.Push("item5");
            mStack.Push("item6");
            mStack.Push("item7");
            mStack.Push("item8");
            mStack.Push("item9");
            mStack.Push("item10");
            Console.WriteLine("Initial Stack count: " + mStack.Count);

            while (mStack.Count > 0) {
                String item = mStack.Pop();
                Console.WriteLine("Popped " + item.ToString() + " off the stack");
                Console.WriteLine("Stack Count: " + mStack.Count);
                Console.WriteLine();
            }
            

            /**
             * Using Queue
             * First In First Out FIFO
             */
            Queue<String> mQueue = new Queue<String>();
            mQueue.Enqueue("item1");
            mQueue.Enqueue("item2");
            mQueue.Enqueue("item3");
            mQueue.Enqueue("item4");
            mQueue.Enqueue("item5");
            mQueue.Enqueue("item6");
            mQueue.Enqueue("item7");
            mQueue.Enqueue("item8");
            mQueue.Enqueue("item9");
            mQueue.Enqueue("item10");

            Console.WriteLine(mQueue.Peek());   
            Console.WriteLine(mQueue.Count);    //returns 3

            String qValue = mQueue.Dequeue();
            Console.WriteLine(qValue.ToString());
            Console.WriteLine("Queue count is: " + mQueue.Count);
            Console.WriteLine(mQueue.Peek());

            /**
             * Dictionary
             */

            Dictionary<String, String> mDictionary = new Dictionary<string, string>();
            mDictionary.Add("key1", "First Item");
            mDictionary.Add("key2", "Second Item");
            mDictionary.Add("key3", "Third Item");

            Console.WriteLine("Item represented by the key 'key1':" + mDictionary["key1"]);
            Console.WriteLine(mDictionary.Remove("key2"));  //returns true because item was deleted

            Console.ReadLine();
        }
    }

}



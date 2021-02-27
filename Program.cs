using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[11];
            numbers[1] = 1;
            numbers[2] = 4; 
            numbers[3] = 65;
            numbers[4] = 47; 
            numbers[5] = 18;
            numbers[6] = 49; 
            numbers[7] = 14;
            numbers[8] = 45; 
            numbers[9] = 11;
            numbers[10] = 414;

            //Console.WriteLine(numbers[5]);

            //for Loop
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Foreach Loop
            //This loop will start counting from 0 position, That's why its showing the very first position as 0. Because we didn't mentioned here the value of numbers[0] positions.
            
            Array.Sort(numbers);
            //After declaring this Sort function this array will be sorted in ascending order
            Array.Reverse(numbers);
            //After this function the array will give the value in descending orders


            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            
            //Types of Array--------------------------------------------------------------------------------------------------------------------
            //ArrayList----------1

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add("Hey Buddy");
            myArrayList.Add('C');
            myArrayList.Add(10.53);

            //We can replace the data my mentioning its position
            //myArrayList[2] = 100;

            //Length - To know about the size of array
            //Console.WriteLine(myArrayList.Count);

            //Remove - to data from the array with mentioning their values
            //myArrayList.Remove(10);
            
            //RemoveAt - To remove data mentioning their position
            //myArrayList.RemoveAt(2);
            
            //RemoveRange - To remove data from one range to another range
            //myArrayList.RemoveRange(1,2);

            //Contains -  to find the value is in the array or not. The answer will be True or false
            //Console.WriteLine(myArrayList.Contains('C'));
            
            //foreach (var item in myArrayList)
            //{
            //    Console.WriteLine(item);
            //}



            //List-----------------2

            List<int> mylist = new List<int>();
            mylist.Add(12);
            mylist.Add(14);
            mylist.Add(13);
            mylist.Add(18);
            mylist.Add(45);
            mylist.Add(47);
            mylist.Add(74);
            mylist.Add(45);

            //count - to know the length of the list
            //Console.WriteLine(mylist.Count);

            //After declaring this Sort function this array will be sorted in ascending order
            mylist.Sort();

            //After this function the array will give the value in descending orders
            mylist.Reverse();

            //Remove - to remove data from the array with mentioning their values
            //Console.WriteLine(mylist.Remove(10));

            //Contains -  to find the value is in the array or not. The answer will be True or false
            //Console.WriteLine(mylist.Contains(12));

            //foreach (var i in mylist)
            //{
            //    Console.WriteLine(i);
            //}


            //Stack----------3
            //LIFO

            Stack<int> myStack = new Stack<int>();
            myStack.Push(14);
            myStack.Push(144);
            myStack.Push(17);
            myStack.Push(15);
            myStack.Push(45);
            myStack.Push(55);
            myStack.Push(77);
            myStack.Push(752);

            //Stack array can be converted into Array.
            int[] theArray = myStack.ToArray();


            //POP() - to remove data from the stack
            //Console.WriteLine(myStack.Pop());

            //peek() - to show or significant the first value.
            //Console.WriteLine(myStack.Peek());

            //contains - is the data in the list or not.
            //Console.WriteLine(myStack.Contains(12)); 

            //foreach (var i in myStack)
            //{
            //    Console.WriteLine(i);
            //}


            //Queue--------------4
            //FIFO

            Queue<char> myQueue = new Queue<char>();
            myQueue.Enqueue('C');
            myQueue.Enqueue('D');
            myQueue.Enqueue('F');
            myQueue.Enqueue('A');
            myQueue.Enqueue('E');
            myQueue.Enqueue('Z');
            myQueue.Enqueue('X');

            //Queue array can be converted into Array.
            char[] aArray = myQueue.ToArray();

            //Dequeue - to remove elements from the queue
            //Console.WriteLine(myQueue.Dequeue());

            //peek() - to show or significant the first value.
            //Console.WriteLine(myQueue.Peek());

            //Count - to count the number of elements
            //Console.WriteLine(myQueue.Count);

            //contains - is the data in the list or not.
            //Console.WriteLine(myQueue.Contains('A'));
            
            //Console.WriteLine("Queue:------------");
            //foreach (var i in myQueue)
            //{
            //    Console.WriteLine(i);
            //}
            
            //Console.WriteLine("Array:------------");
            //for (int i = 0; i < aArray.Length; i++)
            //{
            //    Console.WriteLine(aArray[i]);
            //}



            //HashTable


            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(12,"This");
            myHashtable.Add('c',"An");
            myHashtable.Add(1.2,"kilo");
            myHashtable.Add('D',9.5);
            myHashtable.Add(15,"It");

            //Count - To count the number of hashtable element
            //Console.WriteLine(myHashtable.Count);

            //containsvalue - to find the value is in the list or not
            //Console.WriteLine(myHashtable.ContainsValue("kilo"));

            //contains/ containskey - to find the key is in the list or not
            //Console.WriteLine(myHashtable.Contains(1.2));

            //Remove - to remove the element with value or key
            myHashtable.Remove(1.2);

            //foreach (DictionaryEntry i in myHashtable)
            //{
            //    Console.WriteLine(i.Key +" - "+ i.Value);
            //}
        }
    }
}

using System;

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


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}

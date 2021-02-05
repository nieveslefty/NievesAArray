/* 
 Name: Alexandra Nieves
 Date: 2/5/2021
 Array assignment
*/

using System;

namespace Nieves_A_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[25];
            for(int i = 0; i<myArray.Length; i++)
                Console.WriteLine("Element value = " + (i+1).ToString());
            Console.ReadKey();
        }
    }
}

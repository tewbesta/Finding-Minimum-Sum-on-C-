﻿using System;

namespace ArrayUtils
{
    class ArayUtils
    { 
        public static int method(int [] array)
        { 
            int sum = 0;
            int i = 0;
            while (i < array.Length-1)
            {sum += array[i];
             i++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to sum?");
            int n = int.Parse(Console.ReadLine());
            int[] x=new int [n];
           
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Please enter the {0} number", i + 1);
                x[i]= int.Parse(Console.ReadLine());
            }
            Array.Sort(x);
           
            Console.WriteLine("The minium sum is {0}",method(x));
        }
        
    }
}

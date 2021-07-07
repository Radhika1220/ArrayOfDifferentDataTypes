﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDifferentDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.----To Print Int Array-----");
            Console.WriteLine("2.----To Print Float Array-----");
            Console.WriteLine("3.----To Print Character Array-----");
            //Initalizing the arrays
            int[] intArray = { 12, 34, 56, 78, 98 };
            float[] floatArray = { 5.2f, 6.5f, 7.8f, 9.2f };
            char[] charArray = { 'R', 'A', 'D', 'H', 'I', 'K', 'A' };
            switch (Console.ReadLine())
            {
                case "1":
                    ArrayClass.ToPrintIntArray(intArray);
                    break;
                case "2":
                    ArrayClass.ToPrintFloatArray(floatArray);
                    break;
                case "3":
                    ArrayClass.ToPrintCharArray(charArray);
                    break;
                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;
        
        }
            Console.ReadLine();
        }
    }
}

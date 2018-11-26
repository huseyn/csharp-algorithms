﻿using Algorithms.Exercises.arrays;
using Algorithms.Exercises.conditional_statements;
using Algorithms.Exercises.operators_and_expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11] { 1,2,3,4,5,6,7, 5, 6, 7, 8 };

            foreach (var item in Arrays.FindConsequtiveIncreasingElements(arr))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

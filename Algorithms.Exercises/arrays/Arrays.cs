﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises.arrays
{
    public static class Arrays
    {
        public static int[] MultipleByFiveArray(int[] array) //Exercise 1
        {
            /*
             Write a program, which creates an array of 20 elements of type
             integer and initializes each of the elements with a value equals to the
             index of the element multiplied by 5. Print the elements to the console.
             */
            array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }

            return array;
        }

        public static bool CompareArrays(int[] arr1, int[] arr2) // Exercise 2
        {
            /*
             * Write a program, which reads two arrays from the console and checks
                whether they are equal (two arrays are equal when they are of equal
                length and all of their elements, which have the same index, are equal).
             */
            bool result = false;
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                        result = true;
                    else return false;
                }
                return result;
            }
            else
                return false;
        }

        public static string CheckLexicographicalOrder(char[] arr1, char[] arr2)
        {
            /*
             Write a program, which compares two arrays of type char
                lexicographically (character by character) and checks, which one is first
                in the lexicographical order.
             */
            string result = string.Empty;
            if (arr1.Length != arr2.Length) return "Lenghts are different";
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        result = "First array lexicographical";
                        return result;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        result = "Second array lexicographical";
                        return result;
                    }
                    else
                    {
                        result = "Arrays are equal";
                        return result;
                    }
                }
                return result;
            }

        }
    }
}

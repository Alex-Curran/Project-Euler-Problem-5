/*
 *   Project Euler: Problem 5
 *   Alex Curran 
 *   
 *  2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 *  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 *   
 *  https://projecteuler.net/problem=5
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int answer = Problem_5();

            Console.WriteLine("The smallest positive number evenly divisible by 1 - 20 = {0}", answer);
        }


        /*
         * Since 2520 is the smallest number divisible by 1-10, the smallest number 
         * divisible by 1-20 must be a multiple of 2520.
         * 
         */
        public static int Problem_5()
        {
            // Number to test. Must be a multiple of 2520
            int number = 2520;
            // Used to determine if the number is divisible by 11 - 20 
            int divisible = 0;
            bool complete = false;

            while(!complete)
            {
                number += 2520;
                for (int i = 11; i <= 20; i++)
                {
                    if (number % i == 0)
                    {
                        divisible += 1;
                    }
                }

                if (divisible == 10)
                {
                    complete = true;
                    return number;
                }
                else
                {
                    divisible = 0;
                }  
            }

            return number; 
        }
    }
}

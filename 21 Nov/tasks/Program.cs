﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            Console.WriteLine("Task1:");
            Console.WriteLine();
            Console.WriteLine("Enter Number to compare:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number to compare:");
            int q = Convert.ToInt32(Console.ReadLine());
            int result = (m < q) ? m : q;
            Console.WriteLine("The Smallest Number Is:" + result );
            Console.WriteLine("................................................................................................................");

            //Task2

            Console.WriteLine("Task2:");
            Console.WriteLine();
            Console.WriteLine("Enter Positive or Negeative number:");
            int n = Convert.ToInt32(Console.ReadLine()); ;
            string result2 = (n > 0) ? "Positive" : "Negative";
            Console.WriteLine("The Number Sign:"+result2);
            Console.WriteLine("................................................................................................................");


            //Task3

            Console.WriteLine("Task3:");
            Console.WriteLine();
            int a = 5;
            int b = -9;
            int c = 20;
            if (a > b && b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else if (c > b && b > a)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
            else if (b > c && c > a)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            Console.WriteLine("................................................................................................................");


            //Task4
            Console.WriteLine("Task4:");
            Console.WriteLine();
            int[] arr = { -1, 0, 1, 2, 3 };
            if (arr[0] > arr[1] && arr[0] > arr[2] && arr[0] > arr[3] && arr[0] > arr[4])
            {
                Console.WriteLine(arr[0]);
            }

            else if (arr[1] > arr[0] && arr[1] > arr[2] && arr[1] > arr[3] && arr[1] > arr[4])
            {
                Console.WriteLine(arr[1]);
            }

            else if (arr[2] > arr[0] && arr[2] > arr[1] && arr[2] > arr[3] && arr[2] > arr[4])
            {
                Console.WriteLine(arr[2]);
            }

            else if (arr[3] > arr[0] && arr[3] > arr[1] && arr[3] > arr[2] && arr[3] > arr[4])
            {
                Console.WriteLine(arr[3]);
            }

            else if (arr[4] > arr[1] && arr[4] > arr[2] && arr[4] > arr[3] && arr[4] > arr[0])
            {
                Console.WriteLine(arr[4]);
            }
            Console.WriteLine("................................................................................................................");

            //Task5

            Console.WriteLine("Task5:");
            Console.WriteLine();
            Console.Write("Enter speed in km/h: ");
            int km = Convert.ToInt32(Console.ReadLine());
            double mile = km / 1.6;
            Console.Write("Speed In mph:");
            Console.WriteLine($"{mile} mph");
            Console.WriteLine("................................................................................................................");

            //Task6

            Console.WriteLine("Task6:");
            Console.WriteLine();
            Console.Write("Enter hours:  ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes:  ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Total Minutes:");
            Console.WriteLine(hours * 60 + minutes);
            Console.WriteLine("................................................................................................................");

            //Task7

            Console.WriteLine("Task7:");
            Console.WriteLine();
            Console.Write("Enter minutes:  ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Total Minutes and Hours:");
            Console.WriteLine(minute / 60 + " " + "Hours" + " " + minute % 60 + " " + "minutes");
            Console.WriteLine("................................................................................................................");

            //Task8

            Console.WriteLine("Task8:");
            Console.WriteLine();
            string[] Array = { "Nouran", "Omar", "Tharwat", "Ghadeer", "Mohammed" };

             Console.WriteLine(Array[0].Substring(0, 4));
             Console.WriteLine(Array[1].Substring(0, 4));
             Console.WriteLine(Array[2].Substring(0, 4));
             Console.WriteLine(Array[3].Substring(0, 4));
             Console.WriteLine(Array[4].Substring(0, 4));
            Console.WriteLine("................................................................................................................");

        }
      }
    }


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Task1 Call


            //Task2 call
            Console.WriteLine("The Cube Of Number is : " + Cube());
            Console.WriteLine("........................................................................................................................");

            //Task3 call
            Console.WriteLine();

            //Task4 call
            Console.WriteLine(Days());


        }

        //Task1 code 



        //Task2 code

        static int Cube()
        {
            Console.WriteLine("Task1");
            Console.WriteLine();
            Console.Write("Enter Number to Cube It: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number * number * number;
            return result;
        }

        //Task4 code 

        static int Days()
        {

            Console.WriteLine("Task4");
            Console.WriteLine();
            Console.Write("Enter Your Age in Years: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageindays = age * 365;
            return ageindays;

        }


    }
}
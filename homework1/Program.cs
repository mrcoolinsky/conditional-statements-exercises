﻿using System;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} are equal");
            }

            //2

            Console.WriteLine("enter a number:");
            string number = Console.ReadLine();
            int numberInt;
            Int32.TryParse(number, out numberInt);

            if (numberInt % 2 == 0)
            {
                Console.WriteLine($"Number {numberInt} is even");
            }
            else
            {
                Console.WriteLine($"Number {numberInt} is odd");
            }

            //3

            if (numberInt > 0)
            {
                Console.WriteLine($"Number {numberInt} is positive");
            }
            else if (numberInt < 0)
            {
                Console.WriteLine($"Number {numberInt} is negative");
            }
            else
            {
                Console.WriteLine($"Number is null");
            }

            //4

            Console.WriteLine("enter a year:");
            string year = Console.ReadLine();
            int yearInt;
            Int32.TryParse(year, out yearInt);

            if (yearInt % 4 == 0 && yearInt % 100 != 0)
            {
                Console.WriteLine("The year is leap");
            }
            else if (yearInt % 100 == 0 && yearInt % 400 == 0)
            {
                Console.WriteLine("The year is leap");
            }
            else
            {
                Console.WriteLine("The year is normal");
            }

            //5

            Console.WriteLine("enter your age:");
            string age = Console.ReadLine();
            int ageInt;
            Int32.TryParse(age, out ageInt);
            
            if (ageInt >= 21 && ageInt < 30)
            {
                Console.WriteLine("Możesz zostać posłem lub premierem");
            }
            else if (ageInt >= 30 && ageInt < 35)
            {
                Console.WriteLine("Możesz kandydować do senatu");
            }
            else if (ageInt >= 35)
            {
                Console.WriteLine("Możesz zosać prezydentem");
            }
            else
            {
                Console.WriteLine("Jeteś jeszcze za młody :/");
            }

            //6

            Console.WriteLine("enter your height:");
            string height = Console.ReadLine();
            int heightInt;
            Int32.TryParse(height, out heightInt);

            if (heightInt > 170)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else
            {
                Console.WriteLine("Jesteś niski");
            }

            //7

            Console.WriteLine("enter first number");
            string firstNumber = Console.ReadLine();
            int firstNumberInt;
            Int32.TryParse(firstNumber, out firstNumberInt);

            Console.WriteLine("enter second number");
            string secondNumber = Console.ReadLine();
            int secondNumberInt;
            Int32.TryParse(secondNumber, out secondNumberInt);

            Console.WriteLine("enter third number");
            string thirdNumber = Console.ReadLine();
            int thirdNumberInt;
            Int32.TryParse(thirdNumber, out thirdNumberInt);

            if (firstNumberInt > secondNumberInt && firstNumberInt > thirdNumberInt)
            {
                Console.WriteLine("First number is highest");
            }
            else if (secondNumberInt > firstNumberInt && secondNumberInt > thirdNumberInt)
            {
                Console.WriteLine("Second number is highest");
            }
            else
            {
                Console.WriteLine("Third number is highest");
            }

            //8

            int math = 80;
            int physics = 71;
            int chemistry = 0;
            int sum = math + physics + chemistry;
            

            if ((math >70 && chemistry > 45 && sum >180) || (math+physics) > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

            //9

            int temp = 41;

            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }

            //10



        }
    }
}
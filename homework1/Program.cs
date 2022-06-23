using System;

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

            if (yearInt % 4 == 0 && yearInt % 100 != 0 || yearInt % 400 == 0)
            {
                Console.WriteLine("The year is leap");
            }
        //    else if (yearInt % 100 == 0 && yearInt % 400 == 0)
          //  {
            //   Console.WriteLine("The year is leap");
            //}
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
            else if (ageInt < 35)
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

            int x = 40;
            int y = 55;
            int z = 65;

            if (x<y+z && y<x+z && z<x+y)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            //11

            Console.WriteLine("Please enter a grade");
            string grade = Console.ReadLine();
            int gradeInt;
            Int32.TryParse(grade, out gradeInt);

            switch(gradeInt)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej oceny :)");
                    break;
            }

            //12

            Console.WriteLine("Please enter a number of the day");
            string day = Console.ReadLine();
            int dayInt;
            Int32.TryParse(day, out dayInt);

            switch (dayInt)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia :)");
                    break;
            }

            //13
            Console.WriteLine("Please enter first number");
            string numberOne = Console.ReadLine();
            int numberOneInt;
            Int32.TryParse(numberOne, out numberOneInt);

            Console.WriteLine("Please enter second number");
            string numberSecond = Console.ReadLine();
            int numberSecondInt;
            Int32.TryParse(numberSecond, out numberSecondInt);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            string option = Console.ReadLine();
            int optionInt;
            Int32.TryParse(option, out optionInt);
            decimal result;

            switch(optionInt)
            {
                case 1:
                    result = numberOneInt + numberSecondInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                case 2:
                    result = numberOneInt - numberSecondInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                case 3:
                    result = numberOneInt * numberSecondInt;
                    Console.WriteLine($"Your result: {result}");
                    break;
                case 4:
                    if (numberSecondInt == 0)
                    {
                        Console.WriteLine("You cannot divide by 0");
                    }
                    else
                    {
                        result = (decimal)numberOneInt / (decimal)numberSecondInt;
                        Console.WriteLine($"Your result: {result}");
                    }                    
                    break;
                default:
                    {
                        Console.WriteLine("Please enter another option!");
                        break;
                    }
            }
        }
    }
}

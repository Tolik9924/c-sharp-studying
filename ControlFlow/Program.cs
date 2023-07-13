using System;

namespace ControlFlow
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beatiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }

            // exersises if/else
            Console.WriteLine("Exersises if/else");
            // 1

            Console.WriteLine("Enter number more eaqual 1 and less equal 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // 2
            Console.WriteLine("Enter first number and second number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber;
            if (firstNumber >= secondNumber)
            {
                thirdNumber = firstNumber - 1;
                Console.WriteLine("Number: " + thirdNumber);
            }
            else
            {
                thirdNumber = secondNumber - 1;
                Console.WriteLine("Number: " + thirdNumber);
            }

            // 3
            Console.WriteLine("Enter width and height number");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());        
            if (width > height)
            {            
                Console.WriteLine("Landscape.");
            }
            else
            {             
                Console.WriteLine("Portrait.");
            }

            // 4
            Console.WriteLine("Enter speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed of car");
            int speedOfCar = Convert.ToInt32(Console.ReadLine());
            int count;

            if (speedLimit >= speedOfCar)
            {
                Console.WriteLine("Ok.");
            }
            else if(speedLimit < speedOfCar)
            {
                count = (speedOfCar - speedLimit) / 5;
                if (count > 12)
                {
                    
                    Console.WriteLine("License Suspended.");
                }
                Console.WriteLine("Count: " + count);             
            }

            // For loops
            Console.WriteLine("For loops.");
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // For loops
            Console.WriteLine("Foreach loops.");

            var name = "John Smith";

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

            // Random Class
            Console.WriteLine("Random Class.");

            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);

            // Exersises for

            // 1

            int countOfNumbers = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    countOfNumbers++;
                }
            }
            Console.WriteLine("countOfNumbers: " + countOfNumbers);

            // 2
            int result = 0;
            while (true)
            {
                Console.WriteLine("Type number or ok to exit");
                string enteredNumber = Console.ReadLine();
                if (enteredNumber == "ok")
                {
                    break;
                }
                result += Convert.ToInt32(enteredNumber);
            }
            Console.WriteLine("Result: " + result);

            // 3
            Console.WriteLine("Type number for factorial");
            int factorialNumber = Convert.ToInt32(Console.ReadLine());
            int resultOfFactorialNumber = 1;
            for (var i = 1; i <= factorialNumber; i++)
            {
                resultOfFactorialNumber *= i;
            }
            Console.WriteLine(resultOfFactorialNumber);

            // 4
            var randomNumber = new Random().Next(1, 10);
            for (var i = 1; i <= 4; i++)
            {
                Console.WriteLine("Type random number.");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You lost");
                }
            }

            // 5
            Console.WriteLine("Type series of numbers separated by comma");
            string str = Console.ReadLine();
            int max = 0;

            foreach (var s in str.Split(','))
            {
                int num;
                if (int.TryParse(s, out num))
                    if (max < num)
                    {
                        max = num;
                    }
            }
            Console.WriteLine("Max number: " + max);
        }
    }
}

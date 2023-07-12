using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 2;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Tolik";
            bool isWorking = false;
            const float pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(pi);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            /// type conversation
            Console.WriteLine("Type Conversation");
            int i = 1000;
            byte b = (byte) i;     

            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);
            }
            catch 
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            Console.WriteLine(b);

            /// Operators
            Console.WriteLine("Operators");
            var firstNumber = 10;
            var secondNumber = 3;
            var thirdNumber = 4;

            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine((float) firstNumber / (float) secondNumber);
            Console.WriteLine(firstNumber + secondNumber * thirdNumber);
            Console.WriteLine((firstNumber + secondNumber) * thirdNumber);
            Console.WriteLine(firstNumber > secondNumber);
            Console.WriteLine(firstNumber == secondNumber);
            Console.WriteLine(firstNumber != secondNumber);
            Console.WriteLine(!(firstNumber != secondNumber));
            Console.WriteLine(firstNumber > secondNumber && firstNumber == secondNumber);
            Console.WriteLine(firstNumber > secondNumber || firstNumber == secondNumber);
            Console.WriteLine(!(firstNumber > secondNumber || firstNumber == secondNumber));
        }
    }
}

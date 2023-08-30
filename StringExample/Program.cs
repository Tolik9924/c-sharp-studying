using System.Text;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Tolik Galkevych ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Galkevych", "Halkevych"));

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

            // Summarising Text
            var sentence = "This is going to be a really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

            // StringBuilder
            var builder = new StringBuilder("Hello World");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);

            // task 1

            Console.WriteLine("Task 1");

            Console.WriteLine("Enter few numbers separated by nyphen");
            var numbers_separated_by_nyphen = Console.ReadLine();
            var arr_numbers = numbers_separated_by_nyphen.Split('-');
            var is_Consecutive = false;
            for (int i = 1; i < arr_numbers.Length; i++)
            {
                var first_number = Int32.Parse(arr_numbers[i]);
                var second_number = Int32.Parse(arr_numbers[i - 1]);
                var res = first_number - second_number;
                if (res == 1 || res == -1)
                {
                    is_Consecutive = true;
                }
                else {
                    is_Consecutive = false;
                    break;
                }
            }

            if (is_Consecutive)
            {
                Console.WriteLine("Consecutive");
            } else
            {
                Console.WriteLine("Not Consecutive");
            }

            // Task 2
            Console.WriteLine("Task 2");

            Console.WriteLine("Enter few numbers separated by nyphen");
            var numbers_sep_by_nyphen = Console.ReadLine();
            var wrong_numbers = false;

            if (numbers_sep_by_nyphen.Length == 0)
            {
                System.Environment.Exit(1);
            }

            var arr_numbers_sep_by_nyphen = numbers_sep_by_nyphen.Split('-');

            for (int i = 0; i < arr_numbers_sep_by_nyphen.Length; i++)
            {
                for (int j = i + 1; j < arr_numbers_sep_by_nyphen.Length; j++)
                {
                    if (arr_numbers_sep_by_nyphen[i] == arr_numbers_sep_by_nyphen[j])
                    {
                        wrong_numbers = true;
                        break;
                    }
                }
            }

            if (wrong_numbers)
            {
                Console.WriteLine("Duplicate");
            } else
            {
                Console.WriteLine("Correct numbers");
            }

            // Task 3
            Console.WriteLine("Task 3");

            //Actual Solution

            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }

            // Task 4
        }
    }
}
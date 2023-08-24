using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Lenngth: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Lists
            var lists_of_numbers = new List<int>() { 1, 2, 3, 4 };
            lists_of_numbers.Add(1);
            lists_of_numbers.AddRange(new int[3] { 5, 6, 7 });

            Console.WriteLine("Show result lists of numbers");
            foreach (var number in lists_of_numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + lists_of_numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + lists_of_numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + lists_of_numbers.Count);

            for (var i = 0; i < lists_of_numbers.Count; i++)
            {
                if (lists_of_numbers[i] == 1)
                {
                    lists_of_numbers.Remove(lists_of_numbers[i]);
                }
            }
            foreach (var number in lists_of_numbers)
                Console.WriteLine(number);

            lists_of_numbers.Clear();
            Console.WriteLine("Count: " + lists_of_numbers.Count);

            // Task 1
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter persons who liked your post");
            string usersName = Console.ReadLine();
            string[] subs = usersName.Split(" ");
            if (subs[0] == "")
            {
                Console.WriteLine("No one likes your post.");
            }
            else if (subs.Length <= 2)
            {
                foreach (var sub in subs)
                {
                    Console.WriteLine(sub + " likes your post.");
                }
            }
            else if (subs.Length > 2)
            {
                Console.WriteLine($"{subs[0]}, {subs[1]} and {subs.Length - 2} others like your post.");
            }

            // Task 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter your name.");
            string userName = Console.ReadLine();
            char[] subsOfName = userName.ToCharArray();
            Array.Reverse(subsOfName);
            string result = String.Join("", subsOfName);
            Console.WriteLine("result of task: " + result);

            // Task 3
            Console.WriteLine("Task 3");

            List<int> NotRepeatNumbers()
            {
                Console.WriteLine("Enter 5 numbers.");
                string five_numbers = Console.ReadLine();
                string[] subs_of_numbers = five_numbers.Split(" ");
                var lists_of_five_numbers = new List<int>();
                bool wrong_number = false;
                int temp = 0;

                for (int i = 0; i < subs_of_numbers.Length; i++)
                {
                    lists_of_five_numbers.Add(int.Parse(subs_of_numbers[i]));
                }

                for (int i = 0; i <= lists_of_five_numbers.Count; i++)
                {
                    for (int j = i + 1; j < lists_of_five_numbers.Count - 1; j++)
                    {
                        if (lists_of_five_numbers[i] == lists_of_five_numbers[j])
                        {
                            wrong_number = true;
                            break;
                        }
                    }
                }


                return wrong_number ? NotRepeatNumbers() : lists_of_five_numbers;
            }

            var res = NotRepeatNumbers();
            var temp = 0;

            for (int i = 1; i < res.Count; i++)
            {
                for (int j = 0; j < res.Count - i; j++)
                {
                    if (res[j] > res[j + 1])
                    {
                        temp = res[j];
                        res[j] = res[j + 1];
                        res[j + 1] = temp;
                    }
                }
            }

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            // Task 4
            Console.WriteLine("Task 4");

            List<int> UniqueNumbers()
            {
                Console.WriteLine("Enter 5 numbers or Quit");
                string five_numbers = Console.ReadLine();
                string[] subs_of_numbers = five_numbers.Split(" ");
                List<int> lists_of_five_numbers = new List<int>();

                if (five_numbers != "Quit")
                {
                    for (int i = 0; i < subs_of_numbers.Length; i++)
                    {
                        lists_of_five_numbers.Add(int.Parse(subs_of_numbers[i]));
                    }

                    List<int> unqiue = lists_of_five_numbers.Distinct().ToList();


                    return unqiue;
                }

                return lists_of_five_numbers;
            }

            var unique_numbers = UniqueNumbers();

            if (unique_numbers.Count > 0)
            {
                Console.WriteLine("Unique Numbers");
                foreach (var item in unique_numbers)
                {
                    Console.WriteLine(item);
                }
            }

            // 5 task
            Console.WriteLine("Task 5");

            List<int> EnteredNumbers()
            {
                Console.WriteLine("Write five numbers divided by coma and space.");
                string five_numbers = Console.ReadLine();
                string[] subs_of_numbers = five_numbers.Split(", ");
                List<int> list_of_numbers = new List<int>();

                for (int i = 0; i < subs_of_numbers.Length; i++)
                {
                    list_of_numbers.Add(int.Parse(subs_of_numbers[i]));
                }

                if (subs_of_numbers.Length < 5)
                {
                    Console.WriteLine("Count of list" + lists_of_numbers.Count);
                    Console.WriteLine("Invalid List");
                    Console.WriteLine("Repeat entering number");
                    EnteredNumbers();
                }

                return list_of_numbers;
            }

            List<int> resulting_numbers = EnteredNumbers();

            for (int i = 1; i < resulting_numbers.Count; i++)
            {
                for (int j = 0; j < resulting_numbers.Count - i; j++)
                {
                    if (resulting_numbers[j] > res[j + 1])
                    {
                        temp = resulting_numbers[j];
                        resulting_numbers[j] = resulting_numbers[j + 1];
                        resulting_numbers[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(resulting_numbers[i]);
            }
        }
    }
}

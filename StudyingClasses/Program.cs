﻿using StudyingClasses;

using Amazon;

namespace StuyingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            person.Introduce("Mosh");

            Person person1 = new Person(new DateTime(1982, 1, 1));
            person1.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person1.GetBirthdate());

            Person person2 = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine("Years: {0}", person2.Age);            

            // Methods
            try
            {
                var numb = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Consersion failed.");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");

            // Indexers
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);

            // Stopwatch
            MyTimer time = new MyTimer();
            
            UseMyTime(time);

            // StackOverflow Post
            Post post = new Post();
            post.titleOfPost("Title");
            post.descriptionOfPost("Description");
            Console.WriteLine(post.showPost());
            post.likeDislikePost("like");
            Console.WriteLine(post.showPost());
            post.likeDislikePost("dislike");
            Console.WriteLine(post.showPost());

            // INHERITANCE
            var text = new Text();
            text.Width = 100;
            text.Copy();

            // Composition
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            // Access Modifiers
            Amazon.Customer customer1 = new Customer();
            Amazon.RateCalculate calculator = new RateCalculate();           
        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }

        static void UseMyTime(MyTimer time)
        {
            Console.WriteLine("Write start time or quit.");
            string command = Console.ReadLine();

            if (command == "start")
            {
                time.Start();
                UseMyTime(time);
            }

            if (command == "stop")
            {
                Console.WriteLine("Duration: " + time.GetCurrentTime().ToString());
                time.Stop();
                UseMyTime(time);
            }

            if (command == "quit")
            {
                Console.WriteLine("Thanks for using");
            }

        }
    }
}

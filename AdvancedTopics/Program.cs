using System;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {           
            var number = new Nullable<int>(0);
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            // Delegates
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            // Lambda Expression
            // args => expression
            // () => ...
            // x => ...
            // (x, y, z) => ...

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));

            const int factor = 5;

            Func<int, int> multipler = n => n * factor;

            var result = multipler(10);

            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(b => b.Price < 10);

            /*foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }*/

            // Events
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            // Extinsion Methods
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();

            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);

            // LINQ
            var books1 = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks1 =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            // LINQ Extension Methods
            var cheapBooks = books1
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);                        

            foreach (var book in cheapBooks)
                Console.WriteLine(book + " " + book);

            var book1 = books1.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            Console.WriteLine(book1 == null);
            Console.WriteLine(book1.Title);

            var book2 = books1.FirstOrDefault(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(book2.Title + " " + book2.Price);

            var book3 = books1.LastOrDefault(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(book3.Title + " " + book3.Price);

            var pagedBooks = books1.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks )
            {
                Console.WriteLine(pagedBook.Title);
            }

            var count = books1.Count();

            Console.WriteLine(count);

            var maxPrice = books1.Max(b => b.Price);
            var minPrice = books1.Min(b => b.Price);
            var totalPrices = books1.Sum(b => b.Price);

            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(totalPrices);

            // Nullable Types
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);

            DateTime? date1 = new DateTime(2014, 1, 1);
            DateTime date2 = date1.GetValueOrDefault();
            DateTime? date3 = date2;

            Console.WriteLine(date2);
            Console.WriteLine(date3);

            DateTime? date4 = null;
            DateTime date5 = date4 ?? DateTime.Today;
            DateTime date6 = (date4 != null) ? date4.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date5);

            // Exception Handling

            try
            {
                var calculator = new Calculator();
                var result1 = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            

        }

        static void RemoveEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }               
    }
}

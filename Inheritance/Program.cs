using Inheritance;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("XYZ1234");

        // Upcasting and DownCasting

        // Upcasting
        Text text = new Text();
        Shape shape = text;

        text.Width = 200;
        shape.Width= 100;

        Console.WriteLine(text.Width);

        StreamReader reader = new StreamReader(new MemoryStream());

        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("Mosh");
        list.Add(new Text());

        var anotherList = new List<Shape>();

        // Downcasting
        Shape shape1 = new Text();
        // convert shapt to the text
        Text text1 = (Text)shape;
        
        // boxing and unboxing
        var list1 = new ArrayList();
        list.Add(1);
        list.Add("Mosh");
        list.Add(DateTime.Today);

        var anotherList1 = new List<int>();
        var names = new List<string>();      
    }
}

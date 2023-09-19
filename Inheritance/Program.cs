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

        // Design Stack
        Console.WriteLine("Design Stack");
        MyStack stack = new MyStack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        //stack.Clear();

        Console.WriteLine(stack.ShowCountOfList());

        // Overriding
        var shapes = new List<Shape>();
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());

        var canvas = new Canvas();
        canvas.DrawShape(shapes);

        // Abstract Classes and Members
        var circle = new Circle();
        circle.Draw();

        var rectangle = new Rectangle();
        rectangle.Draw();

        // Design a database connection
        SqlConnection sqlConnection = new SqlConnection("connecting", "sql");
        sqlConnection.Openning();
        sqlConnection.Execute();
        sqlConnection.Closenning();

        OracleConnection oracleConnection = new OracleConnection("connecting", "oracle");
        oracleConnection.Openning();
        oracleConnection.Execute();
        oracleConnection.Closenning();

        // Interfaces and Extensibility
        var dbMigrator = new DbMigrator(new ConsoleLogger());
        dbMigrator.Migrate();

        // WorkflowEngine exercise
        Workflow workflow = new Workflow();
        workflow.Add(new CarEngine());
        workflow.Add(new PlaneEngine());        
        WorkflowEngine engine = new WorkflowEngine();
        engine.Run(workflow);
    }
}

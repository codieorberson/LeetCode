using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Dynamic;
using System.Reflection;

namespace DotNetReference
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables and Data Types
            int number = 10;
            string text = "Hello";
            bool isTrue = true;
            double pi = 3.14;

            // Constants
            const int MaxValue = 100;

            // Enums
            Days today = Days.Wednesday;

            // Control Structures
            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5");
            }
            else if (number == 5)
            {
                Console.WriteLine("Number is 5");
            }
            else
            {
                Console.WriteLine("Number is less than 5");
            }

            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Today is not Sunday");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 10);

            foreach (char c in text)
            {
                Console.WriteLine(c);
            }

            // Object-Oriented Programming
            Person person = new Person { Name = "John", Age = 30 };
            person.Greet();

            Employee employee = new Employee { Name = "Jane", Age = 25, EmployeeId = 123 };
            employee.Greet();

            // Collections
            int[] numbers = new int[5];
            List<int> numberList = new List<int> { 1, 2, 3 };
            Dictionary<string, int> ages = new Dictionary<string, int> { { "John", 30 } };

            // Exception Handling
            try
            {
                int result = number / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Cleanup code");
            }

            // LINQ
            var evenNumbers = from num in numberList
                              where num % 2 == 0
                              select num;

            var oddNumbers = numberList.Where(num => num % 2 != 0);

            // Asynchronous Programming
            var data = GetDataAsync().Result;
            Console.WriteLine(data);

            // File I/O
            string fileContent = File.ReadAllText("example.txt");
            File.WriteAllText("example.txt", "Hello, World!");

            // Delegates and Events
            MyDelegate del = new MyDelegate(MyMethod);
            del("Hello, World!");

            MyEventHandler handler = new MyEventHandler();
            handler.MyEvent += (sender, e) => Console.WriteLine("Event triggered!");
            handler.TriggerEvent();

            // Attributes
            MyClass myClass = new MyClass();
            myClass.MyMethod();

            // Dependency Injection
            IServiceProvider serviceProvider = new ServiceCollection()
                .AddTransient<IMyService, MyService>()
                .BuildServiceProvider();
            var myService = serviceProvider.GetService<IMyService>();
            myService.PerformOperation();

            // ASP.NET Core example (simplified)
            // public class HomeController : Controller {
            //     public IActionResult Index() {
            //         return View();
            //     }
            // }

            // Entity Framework Core example (simplified)
            // using (var context = new MyDbContext()) {
            //     var person = new Person { Name = "John" };
            //     context.People.Add(person);
            //     context.SaveChanges();
            // }

            // Unit Testing with xUnit example (simplified)
            // public class MyTests {
            //     [Fact]
            //     public void TestMethod() {
            //         Assert.Equal(4, 2 + 2);
            //     }
            // }

            // HTTP Client example
            // HttpClient client = new HttpClient();
            // HttpResponseMessage response = await client.GetAsync("https://api.example.com/data");
            // string responseBody = await response.Content.ReadAsStringAsync();

            // Reflection
            Type type = typeof(Person);
            MethodInfo method = type.GetMethod("Greet");
            method.Invoke(person, null);

            // Generics
            MyGenericClass<int> genericClass = new MyGenericClass<int> { Value = 10 };

            // Dynamic Programming
            dynamic obj = new ExpandoObject();
            obj.Name = "John";

            // Multithreading
            Task.Run(() => Console.WriteLine("Background task"));

            Parallel.For(0, 10, i => Console.WriteLine(i));

            object lockObject = new object();
            lock (lockObject)
            {
                Console.WriteLine("Critical section");
            }
        }

        public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        public delegate void MyDelegate(string message);

        public static void MyMethod(string message)
        {
            Console.WriteLine(message);
        }

        public async Task<string> GetDataAsync()
        {
            await Task.Delay(1000);
            return "Hello, World!";
        }
    }

    // Example Classes
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
    }

    public interface IWorker
    {
        void Work();
    }

    public class MyGenericClass<T>
    {
        public T Value { get; set; }
    }

    [Serializable]
    public class MyClass
    {
        [Obsolete("This method is obsolete.")]
        public void MyMethod()
        {
            Console.WriteLine("This method is obsolete.");
        }
    }

    public interface IMyService
    {
        void PerformOperation();
    }

    public class MyService : IMyService
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation...");
        }
    }

    public class MyEventHandler
    {
        public event EventHandler MyEvent;

        public void TriggerEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    // Example EF Core DbContext (simplified)
    // public class MyDbContext : DbContext {
    //     public DbSet<Person> People { get; set; }
    // }
}

using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var constructor = new Constructor();
            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records.");
                Console.WriteLine("3. Delete product by Id.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("please enter 1->4: ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        constructor.Create();
                        break;
                    case 2:
                        constructor.Display();
                        break;
                    case 3:
                        constructor.Delete();
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}
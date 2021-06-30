using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Constructor
    {
        private Dictionary<string, Product> _list = new Dictionary<string, Product>();

        public void Create()
        {
            Console.WriteLine("Please enter id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter Price: ");
            var price = double.Parse(Console.ReadLine());
            _list.Add(id, new Product()
            {
                Id = id,
                Name = name,
                Price = price
            });
        }

        public void Display()
        {
            foreach (var products in _list)
            {
                Console.WriteLine(products.Value.ToString());
            }
        }

        public void Delete()
        {
            Console.WriteLine("please enter id");
            var id = Console.ReadLine();
            if (_list.ContainsKey(id))
            {
                _list.Remove(id);
                Console.WriteLine("successful deletion !");
            }
            else
            {
                Console.WriteLine("Id not found");
            }
        }
    }
}
using System;
using System.Xml.Linq;

namespace LABTasktwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 10, 50);

            product1.Sell();
            product1.Sell();
            product1.Sell();

            product1.ShowInfo();






        }
    }
}

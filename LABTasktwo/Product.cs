using System;
using System.Collections.Generic;
using System.Text;

namespace LABTasktwo
{
    internal class Product
    {
        public string Name;
        public int Price;
        public int Count;
        public int Income;

        public Product(string name, int price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                Income += Price;
            }
            else
            {
                Console.WriteLine("Mehsul Bitmisdir");
            }
            

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nCount: {Count}\nIncome: {Income}");
            
        }
    }


}

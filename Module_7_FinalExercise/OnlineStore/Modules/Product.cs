using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Modules
{
    internal class Product
    {
        private  string[] assortment = {"Товар 1", "Товар 2", "Товар 3", "Товар 4", "Товар 5"};

        public void ShowAssortment()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список товаров:");
            for (int i=0;i<assortment.Length;i++)
            {
                Console.WriteLine($"{i+1} - {assortment[i]}");
            }
            Console.ForegroundColor=ConsoleColor.White;
        }
        public int ShowAssortmentCount()
        {
            return assortment.Length;
        }
        public string ChooseProduct(int choseItem)
        { 
            return assortment[choseItem-1];
        }

    }
}

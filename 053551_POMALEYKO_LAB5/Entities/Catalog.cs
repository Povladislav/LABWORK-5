using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053551_POMALEYKO_LAB5
{

    public class Catalog
    {
        private int command;
        public static event StateHandler onChoose;
        public static MyCustomCollection<Product> collection = new MyCustomCollection<Product>();



        static Catalog()
        {
            collection.Add(new Product("Iphone11", 100));
            collection.Add(new Product("TV LG", 200));
            collection.Add(new Product("Samsung Watch", 85));
            collection.Add(new Product("Earphones JBL", 80));

        }
        public bool ShowProducts()
        {
            if (collection.Count != 0) return true;
            return false;
        }
        public void Display()
        {


            bool alive = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Товары представленные в интернет магазине : ");
            Console.ResetColor();
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine($"{i})" + collection[i].Name + " " + "Цена: " + collection[i].Cost + "$");
            }


            while (alive)
            {
                Console.WriteLine("Выберите номер товара,который хотели бы купить : ");
                try
                {
                    command = Convert.ToInt32(Console.ReadLine());
                    switch (command)
                    {
                        case 0: onChoose?.Invoke(collection[command]); alive = false; break;
                        case 1: onChoose?.Invoke(collection[command]); alive = false; break;
                        case 2: onChoose?.Invoke(collection[command]); alive = false; break;
                        case 3: onChoose?.Invoke(collection[command]); alive = false; break;
                        default: Console.WriteLine("Выберите один из представленных  вариантов!"); break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введите данные корректно!");

                }
            }


        }

    }
}

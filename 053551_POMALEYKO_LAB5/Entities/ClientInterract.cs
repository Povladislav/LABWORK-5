using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053551_POMALEYKO_LAB5
{
    public class ClientInterract
    {
        Catalog catalog = new Catalog();
        private string surName;
        private int choosenum;
        List<Product> productList = new List<Product>();
        public void Interraction(Product p)
        {

            bool surNameIsCorrect = false;
            productList.Add(p);
            while (!surNameIsCorrect)
            {
                Console.WriteLine("Введите вашу фамилию для регистрации заказа :");
                surName = Console.ReadLine().ToUpper();

                foreach (char c in surName)
                {
                    if (c >= '0' && c <= '9')
                    {
                        Console.WriteLine("Введите фамилию корректно!");
                        break;
                    }
                    else
                    {
                        surNameIsCorrect = true;

                        p.NameOfCustromer = surName;
                    }
                }


            }

            if (surNameIsCorrect)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Товар {p.Name} успешно зарегистрирован на фамилию : {surName}");
                Console.ResetColor();
                ChooseProduct();


            }

        }

       
        public void ChooseProduct()
        {
            bool choose = false;
            while (!choose)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1)СДЕЛАТЬ ЕЩЕ ОДИН ЗАКАЗ \n2)ПОСМОТРЕТЬ ИНФОРМАЦИЮ О ЗАКАЗЕ\n3)ВЫХОД ИЗ МАГАЗИНА");
                    choosenum = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    if (choosenum == 1)
                    {
                        choose = true;
                        AnotherBuy();
                        break;
                    }
                    if (choosenum == 2)
                    {
                        choose = true;
                        CheckInfoAboutProducts(productList);
                        break;


                    }
                    if (choosenum == 3)
                    {
                        Environment.Exit(0);

                    }
                }
                catch
                {


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Сделайте корректный выбор!");
                    Console.ResetColor();


                }

            }
        }
        private void AnotherBuy()
        {
            if (Catalog.collection.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Желаете преобрести еще один товар?");
                Console.ResetColor();
                catalog.Display();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В магазине закончились товары!");
                Console.ResetColor();
                ChooseProduct();
            }


        }
        private void CheckInfoAboutProducts(List<Product> list)
        {
            bool nameFound = false;
            int sum = 0;
            Console.WriteLine("Введите вашу фамилию :");
            string _surname = Console.ReadLine().ToUpper();

            foreach (Product p in list)
            {
                if (p.NameOfCustromer == _surname)
                {
                    sum += p.Cost;
                    Console.WriteLine($"На фамилию {_surname} зарегистрировано: {p.Name}");

                    nameFound = true;

                }
            }
            if (nameFound)
            {

                Console.WriteLine($"Общая сумма заказа : {sum}$");
            }
            if (!nameFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("На вашу фамилию ничего не зарегистрировано!");
                Console.ResetColor();
                ChooseProduct();
            }

        }




    }
}

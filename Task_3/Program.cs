using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {


            int numberPrise = UserInterface.InNumInteger("Розмір Прайса: ");


            Price[] prices = new Price[numberPrise];

            //for (int i = 0; i < numberPrise; i++)
            //{
            //    Console.Clear();

            //    string productName = UserInterface.InNumString("Введіть імя товара: ");
            //    string storeName = UserInterface.InNumString("Введіть імя постачальника: "); ;
            //    int cost = UserInterface.InNumInteger("Введыть цінц оовара: ");

            //    prices[i] = new Price(productName, storeName, cost);
            //}

            //для прискорення перевірки
            prices[0] = new Price("111", "Dino", 5678);
            prices[1] = new Price("222", "Dino", 1234);
            prices[2] = new Price("333", "Awrora", 2345);
            prices[3] = new Price("444", "Awrora", 3567);

            prices = prices.OrderBy(name => name.StoreName).ToArray(); //для сортування


            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - вивести сві продукти; 2 - Пошу за постачальником;");
                string menu = UserInterface.InNumString("Виберіть пункт меню: ");

                switch (menu)
                {
                    case "1":
                        {
                            foreach (var item in prices)
                            {
                                item.ShowInfo();
                            }
                            break;
                        }
                    case "2":
                        {
                            string search = UserInterface.InNumString("Імя постачальника ");
                            bool flag = false;
                            try
                            {
                                foreach (var item in prices)
                                {
                                    if (item.StoreName.ToLower() == search.ToLower())
                                    {
                                        item.ShowInfo();
                                        flag = true;
                                    }
                                }

                                if (!flag)
                                    throw new Exception("Тfкого товара нет");

                            }
                            catch (Exception ex)
                            {
                                UserInterface.ShowError(ex.Message);
                            }

                            break;
                        }
                    default:
                        {
                            UserInterface.ShowError("Такого пункта меню немае!");
                            break;
                        }
                }
                Console.ReadKey();
            }




        }
    }
}

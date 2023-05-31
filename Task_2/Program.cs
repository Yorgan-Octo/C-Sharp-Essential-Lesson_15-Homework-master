using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            //UserInterface знаходится в Task_5
            int numberPrise = UserInterface.InNumInteger("Розмір списка працівників: ");

            Worker[] workers = new Worker[numberPrise];

            //for (int i = 0; i < numberPrise; i++)
            //{
            //    Console.Clear();

            //    string nameWorker = UserInterface.InNumString("Введіть імя працівника: ");
            //    string positionWorker = UserInterface.InNumString("Введіть посаду працівника: ");

            //    DateTime dataStartWorker = UserInterface.InData("Рік початку роботи: ");

            //    workers[i] = new Worker(nameWorker, positionWorker, dataStartWorker);
            //}

            //для швидкої перевірки
            workers[0] = new Worker("Dima","Meneger", new DateTime(2021, 12, 12));
            workers[1] = new Worker("Winki", "PR Meneger", new DateTime(2020, 12, 12));
            workers[2] = new Worker("Ron", "Meneger", new DateTime(2013, 12, 12));
            workers[3] = new Worker("Alina", "HR Meneger", new DateTime(2016, 12, 12));
            workers[4] = new Worker("Bumi", "Boss", new DateTime(2010, 12,12));


            workers = workers.OrderBy(worker => worker.NameWorker).ToArray(); //для сортування

            int searchExperience = UserInterface.InNumInteger("Пошук за стажем роботи: ");

            Console.Clear();
            foreach (var item in workers)
            {
                int experience = DateTime.Now.Year - item.DateOfWorkStart.Year;

                if (experience > searchExperience)
                {
                    item.ShowInfo();
                }
            }


            Console.ReadKey();
        }
    }
}

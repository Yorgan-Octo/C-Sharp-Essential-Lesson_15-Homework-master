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

            int numberPrise = UserInterface.InNumInteger("Розмір списка працівників: ");

            Worker[] workers = new Worker[numberPrise];

            for (int i = 0; i < numberPrise; i++)
            {
                Console.Clear();

                string nameWorker = UserInterface.InNumString("Введіть імя працівника: ");
                string positionWorker = UserInterface.InNumString("Введіть посаду працівника: ");

                DateTime dataStartWorker = UserInterface.InData("Дата: ");

                workers[i] = new Worker(nameWorker, positionWorker, dataStartWorker);
            }
            workers = workers.OrderBy(worker => worker.NameWorker).ToArray(); //для сортування









            foreach (var item in workers)
            {
                Console.WriteLine(item.DateOfWorkStart);
            }


            Console.ReadKey();
        }
    }
}

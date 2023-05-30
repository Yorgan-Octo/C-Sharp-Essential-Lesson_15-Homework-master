using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct Worker
    {

        public string NameWorker { get; }
        public string PositionWorker { get; }
        public DateTime DateOfWorkStart { get;  }


        public Worker(string nameWorker, string positionWorker, DateTime dateOfWorkStart)
        {
            NameWorker = nameWorker;
            PositionWorker = positionWorker;
            DateOfWorkStart = dateOfWorkStart;
        }


        public void ShowInfo()
        {

        }

    }
}

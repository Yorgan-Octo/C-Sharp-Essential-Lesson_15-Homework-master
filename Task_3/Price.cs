using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public struct Price
    {
        public string ProductName { get; }
        public string StoreName { get; }
        public int Cost { get; }


        public Price(string productName, string storeName, int cost)
        {
            ProductName = productName;
            StoreName = storeName;
            Cost = cost;
        }

    }
}

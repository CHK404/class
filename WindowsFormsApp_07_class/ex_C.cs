using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_07_class
{
    public partial class Bev
    {
        public Bev(int stack, string bevName, int price)
        {
            Stack = stack;
            BevName = bevName;
            Price = price;

            Console.WriteLine($"{bevName} {stack}개 입고");
        }
    }
}

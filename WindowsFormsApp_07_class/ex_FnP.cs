using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_07_class
{
    public partial class Bev
    {
        private int stack;
        private int money = 10000;
        private string bevName;
        private int price;

        private static int custMoney = 100000;

        public int Stack
        {
            get { return stack; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("재고가 부족합니다.");
                else
                    stack = value;
            }
        }
        public int Money
        {
            get { return money; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("거스름돈이 부족합니다.");
                else
                    money = value;
            }
        }
        public string BevName
        {
            get { return bevName; }
            set { bevName = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    price = 0;
                else price = value;
            }
        }
        public static int CustMoney
        {
            get { return custMoney; }
            set
            {
                if (value < 0)
                    Console.WriteLine("잔액이 부족합니다.");
                else
                    custMoney = value;
            }
        }
        public string Menu
        {
            get
            {
                return $"{bevName}: {price}-{stack}개";
            }
        }
    }
}

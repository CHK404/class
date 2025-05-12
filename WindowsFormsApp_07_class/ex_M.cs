using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_07_class
{
    public partial class Bev
    {
        public void Buy(int amount)
        {
            Stack -= amount;
            CustMoney -= amount * Price;
            Money += amount * Price;

            Console.WriteLine($"{BevName} {amount}개를 구매하셨습니다.");
            Console.WriteLine($"현재 재고는 {stack}개 입니다.");
            Console.WriteLine($"{CustMoney}원 남으셨습니다.");
            Console.WriteLine("==================");
        }
        public void BevInfo()
        {
            Console.WriteLine($"상품명: {BevName}");
            Console.WriteLine($"재고: {stack}");
            Console.WriteLine("==================");
        }
        public static void CustInfo()
        {
            Console.WriteLine($"현재 {CustMoney}원 남으셨습니다.");
        }
    }
}

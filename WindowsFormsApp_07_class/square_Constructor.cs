using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_07_class
{
    public partial class square2
    {
        //4. 기본 생성자
        public square2()
        {
            Length = 1; //기본 값: 한변의 길이 1
            Console.WriteLine("기본 square 객체가 만들어졌습니다.");
        }

        //4-2. 매개변수 생성자
        public square2(int length)
        {
            Length = length;
            Console.WriteLine($"길이 {Length}로 square 객체가 만들어졌습니다.");
        }
    }
}

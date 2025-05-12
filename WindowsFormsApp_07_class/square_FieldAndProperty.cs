using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_07_class
{
    public partial class square2
    /*
     * partial
     * ㄴ 세 파일로 나눠쓴 square 클래스 -> 컴파일 시 자동 병합
     * ㄴ 클래스 이름이 같아야 함
     * ㄴ 같은 namespace여야 함
     */
    {
        // 2. 필드
        private int length; //변의 길이

        // 3. 속성
        public int Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                    length = 0; //음수 방지
                else
                    length = value;
            }
        }
    }
}

using System;

namespace CHAPTER_02._비밀_코드_맞추기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 비밀 코드 맞추기

            //  * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
            //  * 비밀 코드는 a부터 z 사이의 문자이다.
            //  * 컴퓨터는 사용자의 추측을 읽고 자신의 비밀 코드와 비교하며 비밀코드가 앞에 있는지 아니면 뒤에 있는지를 알려준다.(힌트)

            char secretCode = 'h';

            Console.Write("내가 생각한 코드 : ");
            char myCode = Convert.ToChar(Console.ReadLine());

            if (secretCode < myCode)
            {
                Console.WriteLine("HINT : {0}보다 작습니다.", myCode);
            }
            else if (secretCode > myCode)
            {
                Console.WriteLine("HINT : {0}보다 큽니다.", myCode);
            }
            else
            {
                Console.WriteLine("비밀코드를 맞추셨습니다.");
            }
        }
    }
}
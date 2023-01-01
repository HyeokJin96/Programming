using System;

namespace CHAPTER_02._사과를_제일_좋아하는_사람찾기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 사과를 제일 좋아하는 사람찾기

            //  * 사람들 10명에게 아침에 먹는 사과의 개수를 입력하도록 요청
            //  * 프로그램은 데이터를 분석하여 누가 가장 많은 사과를 아침으로 먹었는지를 출력
            //  * 제일 적게 먹을 사람도 찾도록 출력
            //  * 먹은 사과의 개수 순으로 출력

            string[] names = new string[] { "철수", "영희", "민수", "송희", "진수", "지호", "창호", "한비", "민지", "현지" };
            int value = 0;
            int max = 0;
            int min = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}가 아침에 먹은 사과의 개수 : ", names[i]);

                for (int j = 0; j < 10; j++)
                {

                }
            }
        }
    }
}
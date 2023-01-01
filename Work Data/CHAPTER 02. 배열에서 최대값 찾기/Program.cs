namespace CHAPTER_02._배열에서_최대값_찾기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 배열에서 최대값 찾기

            //  * 크기가 100인 배열을 1부터 100 사이의 난수로 채우고 배열 요소 중에서 최대값을 찾는 프로그램을 작성
            //  * 최대값을 찾으려면 반복하기 전에 배열의 첫 번째 요소를 최대값으로 가정하고 두 번째 요소부터 현재의 최대값과 비교한다.
            //  * 더 큰 값이 발견되면 최대값을 교체한다.

            Random random = new Random();

            int[] intArray = new int[101];      //  크기가 100인 배열 생성
            int temp;

            for (int i = 1; i < 100; i++)
            {
                intArray[0] = random.Next(1, 100);
                intArray[i] = random.Next(1, 100);

                if (intArray[i - 1] > intArray[i])
                {
                    intArray[i] = intArray[i - 1];
                }
            }
            Console.WriteLine("최댓값 : {0}", intArray[99]);
        }
    }
}
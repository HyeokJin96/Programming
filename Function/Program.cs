using System;

namespace Function
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  1. 함수(function)란?

            //      * 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결과값을 반환시켜 주는 코드이다.
            //      * 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.
            //      * 함수에는 내장 함수와 상용자 정의 함수가 있다.
            //          1) 내장함수의 사용 용도에 따라 문자열 관련 함수, 날짜 관련 함수, 수학 관련 함수 등으로 나뉘며 이러한 내장 함수를
            //             API(Application Programming Interface)로 표현한다.
            //          2) 사용자 정의 함수는 프로그래머가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수이다.
            //      * static void 함수이름() { 함수 내용 }

            //  2. 매개변수와 반환값

            //      1) 매개변수(인자, 파라미터)가 없는 함수
            //          * 매개변수도 없고 반환값도 없는 함수 형태는 가장 단순한 형태의 함수이다.
            //          * 함수 이름 뒤에 따라오는 괄호에 인자로 아무 값도 지정하지 않는 형태를 의미한다.
            //      2) 매개변수가 있는 함수
            //          * 특정 함수에 인자 값을 1개 이상 전달하는 방식이다.
            //          * 정수형, 실수형, 문자형, 문자열형, 등 여러 가지 데이터 형식을 인자 값으로 전달할 수 있다.
            //      3) 반환값이 있는 함수(결과값이 있는 함수)
            //          * 함수의 처리 결과를 함수를 호출한 쪽으로 반환할 때는 return 키워드를 사용하여 데이터를 돌려줄 수 있다.
            //      4) 매개변수가 가변(여러 개)인 함수
            //          * C#에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한 함수를 여러 개 만들 수 있다.
            //          * 함수 중복 또는 함수 오버로드(overload)라고 한다.

            ShowMessage("매개변수");

            string returnValue = GetString();
            Console.WriteLine(returnValue);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetString()
        {
            return "반환값";
        }
    }
}
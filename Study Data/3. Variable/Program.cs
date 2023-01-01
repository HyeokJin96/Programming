﻿using System;

namespace Variable
{
    public class Program
    {
        static void Main(string[] args)
        {
            //	1. 변수

            //		* 프로그램에서 값을 다루려면 데이터를 메모리에 잠시 보관해 놓고 사용할 수 있는 임시 저장 공간이 필요하다.
            //		* 변수를 사용하려면 먼저 선언을 해야 한다.
            //		* 변수를 만들 때는 변수 이름과 값, 데이터 형식이 필요하다.
            //		* int(데이터 형식) number(변수 이름);(문장의 끝)
            //		* 데이터 형식
            //			1) int : 정수형 테이터를 저장하며 더 큰 정수는 long을 사용한다.
            //			2) string : 문자열 데이터를 저장한다.
            //			3) bool : 참 값 또는 거짓 값을 true와 false 키워드로 저장한다.
            //			4) double : 실수형 데이터를 저장한다. double과 float 모두 실수 저장이 가능하다.
            //			5) object : C#에서 사용하는 모든 데이터를 저장한다. 모든 데이터 형식을 담을 수 있다.
            //		* 변수 이름 설정의 규칙
            //			1) 변수의 첫 글자는 반드시 문자로 지정한다. 숫자는 변수 이름의 처음에 올 수 없다.
            //			2) 길이는 255자 이하로 하고 공백을 포함할 수 없다.
            //			3) C#은 유니코드를 지원하므로 영어, 한글, 한자 등을 사용 가능하고, 영문자와 숫자, 언더스코어(_) 조합으로 사용하며, 기타 특수 기호는 사용할 수 없다.
            //			4) C#에서 사용하는 키워드(예약어나 메서드 등의 이름)는 사용할 수 없다. using, public, class, static, void, Main 등
            //			5) 변수는 대.소문자를 구분하고, 일반적으로 소문자로 시작한다.
            //			6) 변수 이름은 한글로 선언하여 프로그램 코드의 가독성을 높일 수 있지만, 여러 개발자가 공통 언어인 영어를 사용하기에 대체로 한글 변수 이름은 잘 사용하지 않는다.

            int number;                     //	정수형 변수 선언하기

            number = 7;                     //	변수 값에 할당하기

            Console.WriteLine(number);      //	변수 값을 출력하기

            //	2. 리터럴 사용하기

            //		* 변수에는 직접 정수형 또는 문자열 값을 저장할 수 있는데, 이 값 자체를 리터럴(literal)이라고 한다.
            //		* 리터럴 중에는 값 자체를 가지지 않는 널(null) 리터럴도 있다.
            //		* 변수에는 정수 리터럴, 실수 리터럴, 문자열 리터럴 등을 저장하여 사용할 수 있다.
            //		* 정수는 숫자 그대로 표현하고, 실수는 대문자 F 또는 소문자 f를 접미사로 붙여 표현한다.
            //		* 반드시 문자는 작은따옴표로 묶어야 한다.

            Console.WriteLine(1234);        //	정수형 리터럴

            Console.WriteLine(3.14F);       //	실수 리터럴

            Console.WriteLine('A');         //	문자 리터럴

            Console.WriteLine("Hello");     // 문자열 리터럴

            //	3. 변수를 만들어 값 저장 후 사용하기

            int 변수;

            변수 = 1234;

            Console.WriteLine(변수);

            //	4. 변수 선언과 동시에 초기화하기

            //		* 변수를 선언하면 변수 이름으로 메모리 공간이 만들어지는데, 처음에는 쓰레기 값이 저장되어 있는데, 이곳에 실제 사용할 값을 저장하는 것을 초기화라고 한다.

            int 숫자 = 7;     // 변수 선언과 동시에 초기화

            Console.WriteLine(숫자);

            //	5. 형식이 같은 변수 여러 개를 한 번에 선언하기

            //		* C#에서는 데이터 형식이 같은 변수를 콤마(,) 기호로 구분해서 여러 개 선언할 수 있다.

            int 데이터1, 데이터2, 데이터3;       //	변수를 여러 개 선언

            데이터1 = 1;
            데이터2 = 2;
            데이터3 = 3;

            Console.WriteLine("{0}, {1}, {2}", 데이터1, 데이터2, 데이터3);

            //		* 형식이 같은 변수 여러 개를 동일한 값으로 초기화할 때는 좀 더 편하게 = 기호를 사용하여 초기화할 수 있다.

            int A, B, C;

            A = B = C = 10;		//	변수 여러 개를 선언하고 동일한 값으로 초기화

            Console.WriteLine("{0}, {1}, {2}", A, B, C);

            //		* 일반적으로 프로그래밍에서 변서 이름을 짓는 방법은 세 가지이다.
            //			1) 헝가리안 표기법 : 변수 이름에 데이터 형식에 밪는 접두사를 붙인다.	ex)	int intNum = 0;
            //			2) 파스칼 표기법 : 접두사와 단어를 언더스코어(_)로 구분한다.	ex)	int my_num = 0;
            //			3) 낙타 표기법 : 변수 이름의 첫 글자는 소문자로 시작하고, 그다음 단어들의 첫 글자는 대문자로 시작한다.	ex)	int myNum = 0;

            //	6. 상수 사용하기

            //		* 변수를 선언할 때 앞에 const 키워드를 붙이면 변수는 상수(constant)가 된다.
            //		* 한 번 상수로 선언된 변수는 다시 값을 바꿀 수 없고, 반드시 선언과 동시에 초기화 해야 한다.
            //		* 이러한 const 키워드를 붙인 변수를 상수 또는 지역(local) 상수라고 한다.

            const int MAX = 100;        //	정수 형식의 상수 선언과 동시에 초기화

            Console.WriteLine("최댓값 : {0}", MAX);        //	정수 형식의 상수 선언과 동시에 초기화

            //	7. 문자열 입력 관련 메서드

            //		* Console 클래스로는 사용자가 콘솔에서 데이터를 입력하고 이를 다시 콘솔 화면에 출력할 수 있다.
            //			1) Console.ReadLine() : 콘솔에서 한 줄을 입력받습니다. 또 콘솔 앱 프로그램에서는 현재 시점에서 잠시 멈추는 기능이 있어 Enter를 누를 때까지 대기한다.
            //			2) Console.Read() : 콘솔에서 한 문자를 정수로 입력받는다.
            //			3) Console.ReadKey() : 콘솔에서 다음 문자나 사용자가 누른 기능 키를 가져옵니다.

            Console.WriteLine("이름을 입력하세요.");

            string name = Console.ReadLine();

            Console.WriteLine("안녕하세요. {0}님.", name);

            //		* Console.Read() 메서드를 사용하면 콘솔에서 문자를 하나만 입력받을 수 있으며, 입력 값은 우리가 입력한 값과 다르게 문자에 해당하는 정수로 반환된다.
            //		* 정수에 해당하는 문자를 출력할 때는 Convert.ToChar() 메서드를 사용한다.

            int x = Console.Read();

            Console.WriteLine(x);

            Console.WriteLine(Convert.ToChar(x));

            //	8. 형식 변환

            //		* Console.ReadLine() 메서드를 사용하여 콘솔에서 입력받은 데이터는 문자열으로, 문자열 대신 정수나 실수 데이터를 입력받고 싶다면 입력된 문자열을 원하는 형식으로 변환하여야 한다.
            //		* 형식 변환은 크게 암시적(implicit, 묵시적) 형 변환과 명시적(explicit) 형 변환으로 구분할 수 있다.
            //		* 암시적 형 변환은 변환 형식이 안전하게 유지되며 데이터가 손실되지 않아 특수한 구문이 필요 없다.
            //			ex) 숫자 형식 중 int 형식은 그보다 더 큰 long 형식 변수에 그대로 담을 수 있지만, 반대로 long 형식의 변수를 int 변수에 저장하려면 면시적으로 (int)를 붙여 변경해야 한다.
            //		* Convert 클래스를 사용하여 형식 바꾸기
            //			1) Convert.ToString() : 숫자 데이터 형식을 문자열로 변경
            //			2) Convert.ToInt32() : 숫자 데이터 형식을 정수로 변경
            //			3) Convert.ToDouble() : 숫자 데이터 형식을 실수 형식으로 변경
            //			4) Convert.ToChar() : 입력받은 숫자 또는 문자열 하나를 문자로 변경

            double d = 12.34;
            int i = 1234;

            d = i;

            Console.WriteLine("암시적 형식 변환 = " + d);

            d = 12.34;
            i = (int)d;

            Console.WriteLine("명시적 형식 변환 = " + i);

            string s = "";
            s = Convert.ToString(d);

            Console.WriteLine("형식 변환 = " + s);

            //  9. 이진수

            //      * Convert 클래스의 ToString() 메서드는 특정 숫자의 값을 문자열로 변환할 수 있다.
            //      * 정수 값을 이진수 문자열로 얻고 싶다면 Convert.ToString(정수, 2); 형태로 두 번째 옵션에 이진수를 나타내는 2를 지정한다.

            Console.WriteLine(Convert.ToString(10, 2));

            //  10. var 키워드

            //      * 변수를 선언할 때 int, string 등 기본 제공 키워드 대신 var 키워드를 사용하면 입렫되는 값에 따라 자동으로 형식이 결정된다.
            //      * var 키워드로 선언된 변수에 문자열이 들어오면 자동으로 string 형식으로 선언되며, 실수형 데이터가 저장되면 double 형식의 변수가 만들어진다.

            int number_A = 1234;
            var number_B = 1234;
            var name_A = "유혁진";
        }
    }
}
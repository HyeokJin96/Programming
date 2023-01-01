using System;

namespace Data_type
{
    public class Program
    {
        static void Main(string[] args)
        {
            //	1. 숫자 데이터 형식

            //		* C#에서는 숫자 형식의 데이터를 다룰 때 사용하는 int 키워드를 포함하여 여러 가지 키워드를 제공한다.
            //		* 숫자 데이터 형식은 크게 정수 데이터 형식과 소수점이 있는 실수 데이터 형식으로 나뉘며, 다시 부호 있는 숫자와 부호 없는 숫자로 나뉜다.

            //	2. 정수 데어터 형식

            //		* 정수형 키워드에는 s와 u 접두사가 붙는데 이는 signed와 unsigned의 약자로, 부호를 붙이느냐 붙이지 않는냐 하는 차이가 있다.
            //		* 각 정수 데이터 형식의 키워드는 그와 동일한 역할을 하는 닷넷(.NET) 형식을 제공한다.	ex) int = System.Int32
            //			1) 부호 있는(signed) : +, - 부호가 있는 정수형. 즉, 양수와 음수를 모두 지원한다.
            //              (1) sbyte = System.SByte
            //              (2) short = System.Int16
            //              (3) int = System.Int32
            //              (4) long = System.Int64
            //			2) 부호 없는(unsigned)	: 부호 없이 +값만 다루는 정수형. 즉, 양수만 지원한다.
            //              (1) byte = System.Byte
            //              (2) ushort = System.UInt16
            //              (3) Uint = System.UInt32
            //              (4) ulong = System.UInt64

            int min = -123456;      //  정수형이 가질 수 있는 최솟값
            int max = 123456;       //  정수형이 가질 수 있는 최댓값

            Console.WriteLine("int 변수의 최솟값 : {0}", min);
            Console.WriteLine("int 변수의 최댓값 : {0}", max);

            //	3. 부호 있는 정수 데이터 형식

            sbyte iSByte = 127;
            short iInt16 = 32767;
            int iInt32 = 1234567;
            long iInt64 = 9876543211234;

            Console.WriteLine("8비트 sbyte : {0}", iSByte);
            Console.WriteLine("16비트 short : {0}", iInt16);
            Console.WriteLine("32비트 int : {0}", iInt32);
            Console.WriteLine("64비트 long : {0}", iInt64);

            //	4. 부호 없는 정수 데이터 형식

            byte iByte = 255;
            ushort iUInt16 = 65535;
            uint iUInt32 = 4294967295;
            ulong iUInt64 = 18446744073709551615;

            Console.WriteLine("8비트 byte : {0}", iByte);
            Console.WriteLine("16비트 ushort : {0}", iUInt16);
            Console.WriteLine("32비트 uint : {0}", iUInt32);
            Console.WriteLine("64비트 ulong : {0}", iInt64);

            //	5. 실수 데이터 형식

            //      * 실수 데이터는 부동소수점 방식과 10진 방식을 다루는 세 가지 데이터 형식 키워드인 double, float, decimal을 제공한다.
            //      * double, float는 부동소수점 방식이며, decimal은 10진 방식으로 소수점 28자리 정도까지의 자료를 다루는 금융 관련 프로그램을 만들 때 유용하다.
            //          1) double 키워드(System.Double)
            //              * double 데이터 형식은 64비트 실수 데이터를 저장할 수 있다.
            //              * double 변수에 실수 데이터를 입력하면 기본값으로 double 데이터 형식이 된다.
            //              * double 데이터 형식을 명확하게 설정할 때는 실수 데이터 값 뒤에 접미사로 대문자 D 또는 소문자 d를 지정하여 double d =100D; 형태를 사용한다.

            double PI = 3.141592;

            Console.WriteLine("{0}", PI);

            //          2) float 키워드(System.Single)
            //              * float 데이터 형식은 32비트 부동소수점 방식을 사용한다.

            float f = 99.99F;

            Console.WriteLine("{0}", f);

            //          3) decimal 키워드(System.Decimal)
            //              * decimal 키워드는 실수 형식의 데이터를 다룰 때 사용하며, 이진수 체계로 처리되는 double이나 float와 달리 십진수로 표현한다.
            //              * decimal은 128비트의 숫자를 표현할 수 있다.
            //              * float와 double 데이터 형식에 비해서 가장 정밀도가 높은 정확한 자료를 담을 수 있다.
            //              * 값 자체의 범위는 float와 double 데이터 형식에 비해서 작지만, 소수점 28자리까지는 정확도(유효 자릿수)가 높기에 세금과 환율 계산 등 주로 금융 프로그램을 만들 때 사용한다.

            decimal d = 12.34M;

            Console.WriteLine("{0}", d);

            //	6. 숫자 형식의 리터럴 값에 접미사 붙이기

            //      * 정수형 데이터를 표현하는 리터럴을 만들 때는 접미사를 붙인다.
            //      * int 형은 접미사를 따로 붙이지 않고, long 형은 대문자 L과 소문자 l을 접미사로 붙인다. 또한 U와 u를 접미사롤 붙이면 uint를, UL과 ul을 접미사롤 붙이면 ulong 형을 나타낸다.
            //      * 실수형 데이터를 표현하는 리터럴을 만들 때도 접미사를 사용할 수 있다. F 또는 f를 붙이면 float 형을 나타내고, D 또는 d를 붙이면 double 형 M 또는 m은 decimal 형을 나타낸다.

            float ff = 3.14F;
            double dd = 3.14D;
            decimal mm = 3.14M;

            Console.WriteLine("{0}, {1}, {2}", ff, dd, mm);

            //	7. 문자 데이터 형식 : char

            //		* 문자형 변수는 2바이트 공간에 문자 하나를 저장한다.
            //		* 문자형 변수는 char 키워드로 선언하고 값을 초기화할 때는 작은따옴표 2개를 사용하여 문자 하나를 묶어 준다.
            //		* 문자 데이터 형식인 char 키워드로 선언된 변수는 문자 하나를 저장하는 데 사용하며, 16비트 저장 공간을 차지한다.
            //		* 일반적인 영문 및 한글 등 모든 언어 문자를 표현할 수 있다.
            //		* char 자료형에는 문자 여러 개를 저장할 수 없다. 즉, 작은따옴표 안에는 문자 하나만 넣을 수 있다.

            char grade = 'A';
            char kor = '가';

            Console.WriteLine(grade);
            Console.WriteLine(kor);

            //	8. 문자열 데이터 형식 : string

            //		* 일반적으로 가장 많이 사용하는 문자열을 나타내는 데이터 형식으로, string 키워드를 사용하면 문자열 데이터 형식의 변수를 선언할 수 있다.
            //		* 문자열은 반드시 큰따옴표로 묶는다.

            string name = "유혁진";

            Console.WriteLine("안녕하세요. {0}입니다.", name);

            //		1) @ 기호로 여러 줄 문자열 사용 : MultiLineString.cs
            //			* 문자열 앞에 @ 기호를 붙이면 문자열 자체를 그대로 문자열로 저장하며, 이때 이스케이프 시퀀스도 함께 저장한다.

            string multiLines = @"
				안녕하세요.
				반갑습니다.
				";

            Console.WriteLine(multiLines);

            //		2) 문자열 보간법
            //			* 문자열 보간법(string interpolation) 또는 보간된 문자열 기능은 문자열을 묶을 때 편리하게 사용할 수 있다.
            //			* 문자열 템플릿(string template) 또는 템플릿 문자열(template string)이라고도 한다.
            //			* 문자열을 묶어서 결과를 출력할 일이 많을때 효과적으로 문자열을 처리하려고 String.Format() 메서드 등을 주로 사용한다.
            //			* 6.0 버전부터는 템플릿 문자열이라는 문자열 보간법을 제공해서 $"{}" 형태로 문자열을 묶어서 출력하는 간결한 형태를 유지할 수 있다.

            int number = 3;
            string result = "홀수";

            Console.WriteLine($"{number}은(는) {result}입니다.");

            string msg = string.Format("{0}님, {1}", "유혁진", "안녕하세요");

            Console.WriteLine(msg);


            //	9. 논리 데이터 형식 : bool

            //		* 논리 데이터 형식인 참(true) 또는 거짓(false) 값을 저장하려면 bool 키워드를 사용한다.
            //		* bool 키워드로 선언하는 변수는 논리형 값인 참(true)과 거짓(false) 정보를 저장하며, 1비트의 저장 공간을 차지한다.
            //		* bool 키워드에 해당하는 닷넷 형식은 System.Boolean이다.

            bool bln = true;

            Console.WriteLine(bln);

            bool isFalse = false;

            Console.WriteLine(isFalse);

            //	10. 변하지 않는 값 : 상수

            //		* 문자열 변수에 const 키워드를 붙이면 상수로 선언된다.

            const double PI_ = 3.14;
            const string MY_NAME = "유혁진";

            Console.WriteLine(PI_);
            Console.WriteLine(MY_NAME);
        }
    }
}
using System;

namespace Operator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //	1. 단항 연산자

            //		* 단항 연산자는 연산자 하나로 식을 처리한다.
            //			1) + 연산자 : 특정 정수형 변수 값을 그대로 출력한다.
            //			2) - 연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력한다.

            int Avalue = 0;

            Avalue = 8;
            Avalue = +Avalue;

            Console.WriteLine(Avalue);      //	+ 기호를 붙여 있는 그대로 출력

            int Bvalue = 0;

            Bvalue = -8;
            Bvalue = +Bvalue;

            Console.WriteLine(Bvalue);      //	+ 기호를 붙여 있는 그대로 출력

            int Cvalue = 0;

            Cvalue = 8;
            Cvalue = -Cvalue;

            Console.WriteLine(Cvalue);      //	- 기호를 붙여 부호를 반대로 출력

            int Dvalue = 0;

            Dvalue = -8;
            Dvalue = -Dvalue;

            Console.WriteLine(Dvalue);      // - 기호를 붙여 부호를 반대로 출력

            //	2. 변환 연산자 : ()기호로 데이터 형식 변환하기

            //		* ()기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.

            int Anumber = (int)3.14;        //	3.14를 정수(int)로 변환

            Console.WriteLine(Anumber);

            long Bnumber = (long)3.141592;

            Console.WriteLine(Bnumber);

            double Cnumber = (double)3.141592;

            Console.WriteLine(Cnumber);

            //	3. 산술 연산자

            //		* 산술 연산자는 더하기(add), 빼기(substract), 곱하기(multiply), 나누기(divide), 나머지(remainder, modulus)의 수학적 연산을 사용한다.

            int A = 5;
            int B = 10;

            Console.WriteLine(A + B);

            Console.WriteLine(A - B);

            Console.WriteLine(A * B);

            Console.WriteLine(A / B);

            Console.WriteLine(A % B);

            int C = A % B;

            Console.WriteLine("{0} % {1} = {2}", A, B, C);

            //	4. 문자열 연결 연산자

            //		* 산술 연산자 중 하나인 + 연산자는 경우에 따라 산술 연산 또는 문자열 연결 연산을 수행한다.

            Console.WriteLine("Hello" + "World!");

            Console.WriteLine("Hello" + " " + "World!");

            //	5. 할당 연산자(assignment operator)

            //		1) A = B : A에 B 값의 대입
            //		2) A += B : A에 B를 더한 후 그 값을 다시 A에 대입
            //		3) A -= B : A에 B를 뺀 후 그 값을 다시 A에 대입
            //		4) A *= B : A에 B를 곱한 후 그 값을 다시 A에 대입
            //		5) A /= B : A에 B를 나눈 후 몫을 다시 A에 대입
            //		6) A %= B : A에 B를 나눈 후 나머지 값을 다시 A에 대입

            //	6. 증감 연산자

            //		1) ++ (증가 연산자) : 변수 값에 1을 더한다.
            //		2) -- (감소 연산자): 변수 값에 1을 뺀다.
            //		3) 전위 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을 수햏한다.	ex) ++A, --A
            //		4) 후위 증감 연산자 : 정수형 변수 뒤에 연산자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에 변수 값을 증감한다.	ex) A++, A--

            //	7. 관계형 연산자(relational operator)

            //		* 두 항이 큰지, 작은지 또는 같은지 등을 비교하는데 사용한다.
            //		* 관계형 연산자의 결과값은 논리 데이터 형식인 참(True) 또는 거짓(False)으로 출력된다.
            //		* <, <=, >, >=, ==, !=
            //		* == 연산자를 사용하여 문자열을 비교할 수 있다.

            //	8. 논리 연산자(logical operator)

            //		* 논리 연산자는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을 수행한다.
            //		* 연산의 결과 값은 참(True) 또는 거짓(False)의 bool 형식으로 반환되어 Boolean(불리언) 연산자라고도 한다.
            //		* 비교 연산자와 마찬가지로 결과값은 참 또는 거짓을 반환한다.
            //		1) 논리곱 연산자(AND) : &&	ex) A && B
            //			* A항과 B항 모두 참(True)일 때만 참(True), 그렇지 않으면 거짓(False). 즉, 2개 중 하나라도 거짓(False)이면 거짓(False)
            //			* '~이고, 그리고'
            //		2) 논리합 연산자(OR) : ||	ex) A || B
            //			* A항과 B항 모두 거짓(False)일 때만 거짓(False), 그렇지 않으면 참(True). 즉, 2개 중 하나라도 참(True)이면 참(True)
            //			* '~이거나, 또는'
            //		3) 논리부정 연산자(NOT) : !	ex) !A
            //			* A항이 참(True)이면 거짓(False)을, A항이 거짓(False)이면 참(True)을 반환
            //			* '~가 아닌'

            //	9. 비트 연산자

            //		* 비트 연산자(bit operator)는 정수형 데이터 값을 이진수 비트 단위로 연산을 수행할 때 사용한다.
            //		1) 논리곱(AND), & : 비트 값이 둘 다 1일 때만 1, 그렇지 않으면 0
            //		2) 논리합(OR), | : 비트 값이 하나라도 1이면 1, 그렇지 않으면 0
            //		3) 배타적 논리합(XOR, Exclusive OR), ^ : 비트 값이 서로 다를 때만 1, 그렇지 않으면 0
            //		4) NOT, ~ : 비트값이 1이면 0, 0이면 1

            //	10. 시프트 연산자

            //		* 시프트 연산자(shift operator)는 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽(<<) 또는 오른쪽(>>)으로 지정한 비트만큼 이동시킨다.

            //	11. 기타 연산자

            //		1) 조건 연산자
            //			* 조건 연산자(conditional operator)는 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환하며, ? : 형태의 연산자이다.
            //			* 조건 연산자는 항이 3개여서 3항 연산자(ternary operator)라고도 한다.
            //			* 조건식 ? 식1 : 식2;	->	조건식1이 참이면 식1이 실행되고, 조건식이 거짓이면 식2가 실행된다.

            int toper = 3;

            string result = (toper % 2 == 0) ? "짝수" : "홀수";     //	toper가 짝수이면 result 변수에 "짝수"를 담고, 그렇지 않으면 "홀수" 담기

            Console.WriteLine($"{toper}은(는) {result}입니다");

            const int max_size = 20;
            int pageSize = 0;
            pageSize = 10;

            pageSize = (pageSize > max_size) ? max_size : pageSize;     //	page 값이 max_size 값보다 작다	->	pageSize 값 그대로 출력

            Console.WriteLine(pageSize);

            pageSize = 50;

            pageSize = (pageSize > max_size) ? max_size : pageSize;     //	page 값이 max_size 값보다 크다	->	max_size 값으로 출력

            Console.WriteLine(pageSize);

            string Result = "";

            Result = ('A' < 'B') ? "'A'는 'B'보다 작습니다." : "A B C 순서로 커집니다.";      //	'A'는 'B'보다 작으므로 참	->	앞의 문자열을 Result 변수에 저장

            Console.WriteLine(Result);

            Result = ('Z' < 'a') ? "'Z'는 'a'보다 작습니다." : "대문자보다 소문자가 더 큽니다.";        //	'Z'는 'a'보다 작으므로 참	->	앞의 문자열을 Result 변수에 저장

            Console.WriteLine(Result);

            var num = -21;
            var abs = (num < 0) ? -num : num;       //	음수만 부호 변환

            Console.WriteLine($"{num}의 절댓값 : {abs}");

            //		2) 나열(콤마) 연산자
            //			* 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용하는 연산자를 콤마 연산자(comma operator) 또는 나열 연산가라고 한다.
            //		3) sizeof 연산자
            //			* sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다.
            //			* sizeof(int) 형태로 사용하며, int의 데이터 형식 크기인 4가 값으로 나온다.

            //	12. 연산자 우선순위

            //		* 연산자 여러 개를 함께 사용할 때는 연산자 우선순위(precedence)에 따라 계산된다.
            //		* 괄호 연산자 - 증감 연산자 - 산술 연산자 - 연결 연산자 - 관계 연산자 - 논리 연산자 순으로 우선순위가 정해진다.
        }
    }
}
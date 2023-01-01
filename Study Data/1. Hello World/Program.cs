using System;
//	네임 스페이스 선언부 : 자주 사용하는 네임스페이스를 위쪽에 미리 선언해 둘 수 있다.
//		* 콘솔 화면에 문자열을 출력하려면 네임스페이스, 클래스, 메서드(); 형태로 사용해야 한다.
//		* using 키워드를 사용하여 네임스페이스를 생략하고 클래스, 메서드(); 형태로 줄여서 사용할 수 있다.

//	1. using을 사용하지 않는 코드의 형태

//		class Program
//	{
//		static void Main(string[] args)
//		{
//			System.Console.WriteLine("Hello, World!");
//		}
//	}

//	2. using을 사용하는 코드 형태

//		using System;

//		class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("Hello, World!");
//		}
//	}

//	3. using static 구문
//		* C# 6.0 버전 이후부터는 using static System.Console; 구문으로 System.Console을 생략한 Writeline() 메서드만 사용할 수 있다.

//		using static System.Console;

//		class MyClass
//	{
//		static void Main(string[] args)
//		{
//			Writeline("Hello, World!");
//		}
//	}

//	4. 참고
//		* 다음과 같이 구문 2개를 동시에 위쪽에 둘 수도 있다.
//		* using static System.Condole;
//		* using static System.Math;

namespace Hello_World
//	프로그램 이름을 설정 할 수 있다.
{
    public class Program
    //	모든 요소들이 클래스 안에서 이루어져야 한다.
    {
        static void Main(string[] args)
        //	Main() 메서드
        //		* C# 기본 구조에서 반드시 사용되는 Main() 메서드는 프로그램의 시작점이다.
        //		* 반드시 Main() 메서드가 있어야 하고 Main() 메서드에서 프로그램을 실행하고 종료한다.
        //		* Main() 메서드 앞에 static 키워드가 있어 개체를 생성하지 않고 바로 클래스에 있는 Main() 메서드를 실행할 수 있다.
        //		* Main() 메서드가 2개이면 "프로그램에 진입점이 2개 이상 정의되어 있습니다."라는 에러 메시지가 출력되어 프로그램이 컴파일되지 않는다.
        //		* svm + TAP + TAP : 자동으로 코드 블록을 작성한다. + 자주 사용하는 Console.WriteLine(); -> cw + TAP + TAP
        {
            //  1. 컴퓨터 프로그램(Computer Program)

            //      * 컴퓨터는 하드웨어(Hardware)와 소프트웨어(Software)로 구성된다.
            //      * 하드웨어는 PC, 스마트폰 같은 장치를 의미하고, 소프트웨어는 이러한 하드웨어에 설치된 운영체제, 앱 등을 의미한다.
            //      * 소프트웨어를 만드는 행위를 프로그래밍(Programming)이라고 하며, 소프트웨어를 만드는 사람을 프로그래머(Programmer) 또는 개발자(Developer)라고 한다.
            //      * 프로그램(Program)이란 우리가 하고자 하는 작업을 컴퓨터에게 전달하여 주는 역할을 하는 것이다.
            //      * 프로그램 안에는 "무엇을 어떤 식으로 해라" 와 같은 형태의 명령어(Instruction)들이 들어 있다.
            //      * 명령으로 일을 지시할 수 있도록 프로그램을 만드는 소프트웨어가 바로 프로그래밍 언어이다.
            //      * 프로그래밍 언어에는 C, C++, C#, Java, JavaScript, Python 등 많은 언어가 있다.

            //      * 코드(Code) : 텍스트로 된 소프트웨어를 만드는 명령 집합으로, 소스(Source)라고도 한다.
            //      * 코딩(Coding) : 프로그래밍 언어의 코드로 프로그램을 만드는 과정이다.
            //      * 컴파일(Compile) : 프로그램 소스 코드를 컴퓨터 등 하드웨어가 실행할 수 있는 기계 코드로 변환하는 프로그램을 컴파일러(Compiler)라고 하며, 변환하는 과정을 컴파일이라고 한다.

            //  2. C#의 기본 코드 구조

            //      using System;
            //      class Program
            //      {
            //          static void Main()
            //          {
            //              Console.WriteLine("Hello World!");
            //          }
            //      }
            //      * C# 프로그램은 class 와 Main() 메서드가 반드시 있어야 한다.

            //  3. C# 기본 문법

            //      1) Console.WriteLine()과 Console.Write() 메서드

            Console.Write("줄 바꿈 없음");
            Console.WriteLine("줄 바꿈 포함");

            //      2) 줄 바꿈 기호 : \n

            Console.WriteLine("줄\n바꿈");

            //      3) 주석문(코드 설명문)
            //          * 주석문(Comment)은 실행에 영향을 주지 않는 코드 설명문으로 프로그램 설명이나 프로그램 이름, 사용자 이름, 작성일 등 필요한 내용을 기록하는 용도로 사용한다.
            //          * 주석문은 프로그램을 컴파일할 때 실행되지 않고 실행 파일에도 영향을 주지 않는다.
            //          * 주석문은 크게 한 줄 주석(//)과 여러 줄 주석(/* */)으로 나눌 수 있다.

            //      4) 이스케이프 시퀀스
            //          * \n : 한 줄 내리기, newline
            //          * \t : Tab 들여쓰기, Tab
            //          * \r : 캐리지 리턴*줄의 시작으로 이동), carriage-return
            //          * \' : 작은따옴표 문자 하나 출력
            //          * \" : 큰따옴표 문자 하나 출력

            //      5) 자리 표시자
            //          * 프로그램 실행 결과를 화면에 출력할 때 사용하는 출력문 등에는 자리표시자(틀) 개념을 이용해서 출력 서식을 지정할 수 있다.
            //          * {n} 형태로 {0}, {1}, {2} 순서대로 자리를 만들고 그 다음에 있는 값을 차례로 넘겨받아 출력한다.
            //          * {0}, {1} 식으로 뒤에 이어 나올 값에 대한 자리 번호(인덱스)를 지정해 놓는 방법을 자리 표시자(place holder) 또는 서식 지정자(format specifier)라고 한다.

            Console.WriteLine("안녕하세요 제 이름은 {0}이고, 나이는 {1}이며, 국적은 {2}입니다.", "유혁진", "27", "대한민국");
        }
    }
}
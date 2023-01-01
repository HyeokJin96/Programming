﻿using System;

namespace Basic_grammer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //	1. 출력문

            //	    * Console.WriteLine()과 Console.Write() 메서드
            //		    1) Console.WriteLine("명령 프롬프트에 출력할 내용") : 자동으로 줄 바꿈을 한다.

            Console.WriteLine("Hello, World!");

            //		    2) Console.Write("명령 프롬프트에 출력할 내용") : 자동으로 줄 바꿈을 하지않는다.

            Console.Write("Hello, World!");

            //  2. 주석문(코드 설명문)

            //      * 주석문(comment)은 실행에 영향을 주지 않는 코드 설명문으로 프로그램 설명이다 프로그램 이름, 사용자 이름, 작성일 등 필요한 내용을 기록하는 용도로 사용한다.
            //      * 주석문은 프로그램을 컴파일(compile)할 때 실행되지 않고 실행 파일에도 영향을 주지 않는다.
            //      * 주석문을 사용하여 소스 코드를 지우지 않고 실행되지 않게 숨길 수 있다.
            //      * 슬래시 기호를 2개 사용하여 더블슬래시(//)로 표기하면 뒤의 나머지 코드들을 주석으로 처리한다.
            //      * 한 줄 주석과 여러 줄 주석
            //          1) 한 줄 주석 : 더블 슬래시(//)를 사용하여 뒤에 나오는 모든 구문을 주석 처리한다.
            //              // Console.WriteLine("현재 구문을 실행되지 않습니다.");
            //          2) 여러 줄(블록) 주석 : 슬래시 별표(/*)로 시작해서 별표 슬래시(*/) 사이의 모든 내용을 주석으로 처리한다.
                            /*
                            Console.WriteLine("현재 구문은 실행되지 않습니다.");
                            Console.WriteLine("현재 구문은 실행되지 않습니다.");
                            */

            //  3. 들여쓰기

            //      * 프로그램 소스 코드는 가독성(readability)를 고려하여 들여쓰기(indent)를 해야한다.
            //      * 일반적으로 시작 중괄호 다음 코드는 들여쓰기를 한다.
            //      * 들여쓰기는 공백 4칸을 사용하며 비주얼 스튜디오 에서는 TAP을 한 번 누르면 기본값으로 4칸을 들여쓰기 한다.
            //      * 들여쓰기는 프로그램 코드의 시작과 끝을 명확히 해서 나중에 코드를 다시 살펴보거나 다른 사람이 보았을 때 이해하기 쉽게 하려는 것이므로, 동일한 기준으로 들여쓰기를 해야한다.
            //      * 도구 옵션에서 탭 크기를 수정할 수 있다.
            //      * Ctrl+R, Ctrl+W 를 사용하여 공백을 시각적으로 표현할 수 있다.

            //  4. 공백 처리

            //      * C#에서 공백(whitespace)은 무시된다.
            //      * 프로그램 코드를 작성할 때 명령어 사이의 점(.) 기호와 괄호 사이의 공백은 무시되고, 줄 바꿈 또한 프로그램 실행에 영향을 주지 않는다.

            //  5. 이스케이프 시퀀스

            //      * C#은 WriteLine() 메서드에서 사용할 확장 문자를 제공하는데, 이를 이스케이프 시퀀스(escape sequence)라고 한다.
            //          1) \n : 한 줄 내리기(다음 행으로 이동), newline
            //          2) \t : TAP 들여쓰기(TAP 크기만큼 들여쓰기). tab
            //          3) \r : 캐리지 리턴(줄의 시작으로 이동), carriage-return
            //          4) \' : 작은따옴표 문자 하나 출력
            //          5) \" : 큰따옴표 문자 하나 출력

            //  6. 자리 표시자

            //      * 프로그램 실행 결과를 화면에 출력할 때 사용하는 출력문 등에서는 자리 표시자(틀) 개념을 이용해서 출력 서식을 지정할 수 있다.
            //      * {n} 형태로 {0}, {1}. {2} 순서대로 자리를 만들고 그 다음에 있는 값을 차례로 넘겨받아 출력한다.
            //      * {0}, {1} 식으로 뒤에 이어 나올 값에 대한 자리 번호(인덱스)를 지정해 놓는 방법을 자리 표시자(place holder) 또는 서식 지정자(format specifier)라고 한다.

            Console.WriteLine("{0}", "Hello, World!");
            Console.WriteLine("{0}, {0}", "Hello, World!");
            Console.WriteLine("{0}, {1}", "Hello", "World!");
            Console.WriteLine("{1}, {0}", "Hello", "World!");
        }
    }
}
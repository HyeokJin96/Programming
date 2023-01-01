using System;

namespace CHAPTER_02._자음과_모음_개수_세기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 자음과 모음 개수 세기

            //  * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성

            Console.WriteLine("영문자를 입력하세요. 입력을 마치려면 \'0\'을 입력하세요.");

            int consonant = 0;
            int vowel = 0;
            bool finish = false;

            while (finish == false)
            {
                char userInput = Convert.ToChar(Console.ReadLine());

                switch (userInput)
                {
                    case 'a':
                        vowel = vowel + 1;
                        break;
                    case 'e':
                        vowel = vowel + 1;
                        break;
                    case 'i':
                        vowel = vowel + 1;
                        break;
                    case 'o':
                        vowel = vowel + 1;
                        break;
                    case 'u':
                        vowel = vowel + 1;
                        break;
                    case '0':
                        finish = true;
                        break;
                    default:
                        consonant = consonant + 1;
                        break;
                }
            }
            Console.WriteLine($"자음 : {consonant}");
            Console.WriteLine($"모음 : {vowel}");
        }
    }
}
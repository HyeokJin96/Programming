using System;

namespace CHAPTER_01._Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB 01. 사용자에게 주어, 동사, 목적어를 각각 물어보고 이것들을 합하여(주어 + 동사 + 목적어) 형태로 출력하는 프로그램을 작성

            Console.WriteLine("주어");
            string Subject = Console.ReadLine();

            Console.WriteLine("동사");
            string Verb = Console.ReadLine();

            Console.WriteLine("목적어");
            string Object = Console.ReadLine();

            Console.WriteLine(Subject + Object + Verb);

            Console.WriteLine("------------------------------");

            //  LAB 02. 사용자의 나이를 물어보고 10년 후에 몇 살이 되는지를 출력하는 프로그램을 작성

            Console.WriteLine("나이를 입력하세요");

            int age = Convert.ToInt32(Console.ReadLine());
            int new_age = age + 10;

            Console.WriteLine("10년 후에는 {0}살이 됩니다.", new_age);

            Console.WriteLine("------------------------------");

            //  LAB 03. 직각 삼각형의 양면 길이를 읽어서 빗변 길이를 계산하는 프로그램을 작성

            double A = 3;
            Console.WriteLine("높이 : {0}", A);

            double B = 4;
            Console.WriteLine("밑변 : {0}", B);

            double C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

            Console.WriteLine("빗변 : {0}", C);

            //  LAB 04. 상자의 길이(L), 너비(W), 높이(H)를 입력하는 메시지를 표시한 후 상자의 부피와 표면적을 계산하여 표시하는 프로그램을 작성

            Console.WriteLine("상자의 길이를 입력하세요");
            int L = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("상자의 너비를 입력하세요");
            int W = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("상자의 높이를 입력하세요");
            int H = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("상자의 길이 : {0}", L);
            Console.WriteLine("상자의 너비 : {0}", W);
            Console.WriteLine("상자의 높이 : {0}", H);

            int volume = L * W * H;
            Console.WriteLine("상자의 부피 : {0}", volume);

            int surface_area = 2 * ((L * W) + (L * H) + (H * W));
            Console.WriteLine("상자의 표면적 : {0}", surface_area);

            Console.WriteLine("------------------------------");

            //  LAB 05. 퀴즈, 중간고사, 기말고사 성적을 사용자로부터 입력받아서 성적 총합을 계산하는 프로그램을 작성

            Console.WriteLine("퀴즈 성적을 입력하세요");
            int quiz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("중간고사 성적을 입력하세요");
            int midterm_exam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("기말고사 성적을 입력하세요");
            int final_exam = Convert.ToInt32(Console.ReadLine());

            int total = quiz + midterm_exam + final_exam;

            Console.WriteLine("퀴즈 성적 : {0}", quiz);
            Console.WriteLine("중간고사 성적 : {0}", midterm_exam);
            Console.WriteLine("기말고사 성적 : {0}", final_exam);
            Console.WriteLine("성적 총합 : {0}", total);
        }
    }
}
using System;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int userInput;

            list.Add(1);
            list.Add(2);
            list.Add(3);

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;

            foreach (var n in list)
            {
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("{0}번 : 공격하기", number1);
                            break;
                        case 2:
                            Console.WriteLine("{0}번 : 방어하기", number2);
                            break;
                        case 3:
                            Console.WriteLine("{0}번 : 도망가기", number3);
                            break;
                        default:
                            break;
                    }
            }
            Console.WriteLine("==================================");

            int.TryParse(Console.ReadLine(), out userInput);

            if (userInput == 1)
            {
                list.Remove(1);
                number2 = 1;
                number3 = 2;
            }
            else if (userInput == 2)
            {
                list.Remove(2);
                number3 = 2;
            }
            else if (userInput == 3)
            {
                list.Remove(3);
            }
            Console.WriteLine("==================================");

            foreach (var n in list)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("{0}번 : 공격하기", number1);
                        break;
                    case 2:
                        Console.WriteLine("{0}번 : 방어하기", number2);
                        break;
                    case 3:
                        Console.WriteLine("{0}번 : 도망가기", number3);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("==================================");



            int hp = 50;
            int maxhp = hp;


            Console.WriteLine("아픔.");
            hp -= 20;
            Console.WriteLine(hp);
            Console.ReadLine();

            int ww = 20;

            if (hp + ww >= maxhp)
            {
                hp = maxhp;
            }
            else
            {
                hp += 50;
            }
            Console.WriteLine("회복함");
            Console.WriteLine(hp);

            Console.WriteLine("==================================");


            Console.WriteLine("휴식 선택함");

            int[] intArray = new int[10] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1 };

            for (int i = 0; i < intArray.Length; i++)
            {
            if (intArray[i])
            {

            }

            }



        }   //  main

    }
}
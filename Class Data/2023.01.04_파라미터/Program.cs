using System;

namespace _2023._01._04_파라미터
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 Parameter = new Class1();

            int number1 = 10;
            int number2 = 20;
            Parameter.ValueTypeParam(number1, number2);
            Console.WriteLine("[Main]  firstNumber : {0}, secondNumber : {1}", number1, number2);

            Parameter.RefTypeParam(ref number1, ref number2);
            Console.WriteLine("[Main.ref]  firstNumber : {0}, secondNumber : {1}", number1, number2);

            int number;
            Parameter.OutTypeParam(out number);
            Console.WriteLine("[Main.out]  Number : {0}", number);

            string strNumber1 = "***";
            string strNumber2 = "100";
            int intNumber;
            int.TryParse(strNumber1, out intNumber);
            Console.WriteLine(intNumber);
            int.TryParse(strNumber2, out intNumber);
            Console.WriteLine(intNumber);

            Parameter.FlexibleTypeParam(1, 2, 3, 10, 40, 100, 111, 123, 130);

            Random random = new Random();
        }
    }
}
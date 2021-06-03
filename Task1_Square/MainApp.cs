using System;

namespace Task1_Square
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("세제곱 할 숫자(정수)를 입력해주세요 : ");
            string input = Console.ReadLine();
            int a = int.Parse(input); 
            int result = a * a * a;
            Console.WriteLine("입력한 값의 세제곱은 : {0}", result);

        }
    }
}

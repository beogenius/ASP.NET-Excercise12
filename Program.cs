using System;

namespace ASP.NET_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Hello World 2");

            int num1, num2, temp;
            Console.WriteLine("Nhap so dau tien");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So thu 2");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Sau khi trao doi");
            Console.WriteLine("So thu 1 la " + num1);
            Console.WriteLine("So thu 2 la " + num2);

            Console.Read();

        }
    }
}

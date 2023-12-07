
using System;
namespace UsingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            float Usd;
            float Vnd = 23000f;
            Console.WriteLine("Nhap so tien muon quy doi: ");
            Usd = float.Parse(Console.ReadLine());
            Console.WriteLine("Ti gia hien tai la 1 Usd doi duoc " +Vnd);
            Console.WriteLine("So tien chuyen doi theo ty gia hien tai la:" + Usd * Vnd);
            Console.ReadKey();
        }
    }
}

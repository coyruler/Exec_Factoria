using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * int number;

			// 計算數字階乘(Factorial)
			number = 6;
			Console.WriteLine($"{number} 的階乘等於 {GetFactorial(number)}");

			number = 20;
			Console.WriteLine($"{number} 的階乘等於 {GetFactorial(number)}");
             */
            Console.WriteLine("請輸入要計算階乘的值");
            string number = Console.ReadLine();
            int value = Convert.ToInt32(number);
            int result = value;
            
            for (int i = 1; i < value; i++) 
            {
                result *= i;
                if(result < 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }
            Console.WriteLine($"{number} 階乘等於{result}");

        }
    }
}

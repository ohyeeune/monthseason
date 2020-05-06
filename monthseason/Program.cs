using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String month;
            Console.Write("몇 월? : ");
            month = Console.ReadLine();

            if(month.Contains("12") || month.Contains("1") && month.Contains("2"))
            {
                Console.WriteLine("겨울입니다~");
            } else if (month.Contains("3") || month.Contains("4") || month.Contains("5"))
            {
                Console.WriteLine("봄입니다~");
            }
            else if (month.Contains("6") || month.Contains("7") || month.Contains("8"))
            {
                Console.WriteLine("여름입니다~");
            }
            else if (month.Contains("9") || month.Contains("10") || month.Contains("11"))
            {
                Console.WriteLine("가을입니다~");
            } else
            {
                Console.WriteLine("잘못 입력하셨어요!");
            }
        }
    }
}

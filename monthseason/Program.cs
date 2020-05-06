using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String month;
            Console.Write("몇 월? : ");
            month = Console.ReadLine();
            month = Regex.Replace(month, @"\d", ""); // 문자열에서 숫자 추출

            switch(month)
            {
                case "12":
                case "01":
                case "1":
                case "02":
                case "2":
                    Console.WriteLine("겨울입니다!");
                    break;
                case "03":
                case "3":
                case "04":
                case "4":
                case "05":
                case "5":
                    Console.WriteLine("봄입니다!");
                    break;
                case "06":
                case "6":
                case "07":
                case "7":
                case "08":
                case "8":
                    Console.WriteLine("여름입니다!");
                    break;
                case "09":
                case "9":
                case "10":
                case "11":
                    Console.WriteLine("가을입니다!");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨어요ㅠ!!");
                    break;
            }

           /* if(month.Contains("12") || month.Contains("1") && month.Contains("2"))
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
            }*/
        }
    }
}

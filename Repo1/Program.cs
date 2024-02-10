using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo1
{
   
    class Program
    {
        static bool LeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0 ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
          
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (LeapYear(year))
            {
                Console.WriteLine($" {year}  високосный год");
            }
            else
            {
                Console.WriteLine($" {year} не високосный год");
            }
        }
    }
}

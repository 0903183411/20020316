using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App0309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("請輸入一個分數");
            score = Convert.ToInt32(Console.ReadLine());
            string result = score >= 60 ? "及格" : "不及格";
            Console.WriteLine("同學你{0}",result);
            Console.ReadLine();
        }
    }
}

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
            string name;
            int num;
            char sex;
            double score;
            Console.WriteLine("輸入姓名:");
            name = Console.ReadLine();
            Console.WriteLine("輸入性別 M 表男生，F 表女生:");
            sex = Convert.ToChar( Console.ReadLine());
            Console.WriteLine("輸入學號:");
            num = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("輸入成績:");
            score = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("輸出結果");
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("學號:" + num);
            Console.WriteLine("性別:" + sex);
            Console.WriteLine("成績:" + score);
            Console.ReadLine();

        }
    }
}

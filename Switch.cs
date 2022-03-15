using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    internal class Program
    {
        public class Global

        {

            public static int max = 0;

        }

        static void Main(string[] args)
        {
        int max = 0, min = 0;
        Found:
            Console.Clear();
            Console.Write("功能選項: \n");
            Console.Write("1) 讀入5個整數放在陣列中: \n");
            Console.Write("2) 找出陣列最大值並顯示 \n");
            Console.Write("3) 找出陣列最小值並顯示: \n");
            Console.Write("4) 結束: \n");

            char sel = '0';
            sel = char.Parse(ReadLine());

            while (sel != '4')
            {
                switch (sel)
                {
                    case '1':
                        Console.Write("你選擇功能1\n\n");
                        int[] num = new int[5];
                        int[] array = new int[5];

                        Console.WriteLine("請輸入5個數:");
                        for (int i = 0; i < 5; i++)
                        {
                            string s = Console.ReadLine();
                            int x = int.Parse(s);
                            num[i] = x;

                        }
                        max = num[0];
                        for (int n = 1; n < 5; n++)
                        {
                            if (max < num[n])
                                max = num[n];

                        }
                        Console.WriteLine("最大值是 {0}", max);
                        min = num[0];

                        for (int a = 1; a < 5; a++)
                        {
                            if (min > num[a])
                                min = num[a];
                        }
                        Console.WriteLine("最小值是 {0}", min);
                        int all = 0;
                        for (int h = 0; h < 5; h++)
                        {
                            all = all + num[h];
                        }

                        break;
                    case '2':
                        Console.WriteLine("最大值是 {0}",max);
                        break;
                    case '3':
                        Console.WriteLine("最小值是 {0}", min);
                        break;
                    default: //輸入0~6以外的數值
                        WriteLine("數字不正確，重新輸人");
                        break;
                }
                Console.WriteLine("按任意建重新使用選單");
                Console.ReadKey();
                goto Found;
            }




        }
    }
}

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
            Employee person1;                    //宣告person1物件屬於Employee類別
            person1 = new Employee();        //建立person1物件屬於Employee類別
            person1.EmpID = "10223101";      	//設定EmpID編號欄位
            person1.EmpName = "王一";	//設定EmpName姓名欄位
            person1.age = -20;
            person1.DP = "操作部";
            person1.EmpSalary = 28000;  	//設定EmpSalay薪資欄位
            person1.ShowInfo();

            Employee person2 = new Employee();   //宣告並建立person2物件屬於Employee類別
            person2.EmpID = "10223102";
            person2.EmpName = "李二";
            person2.age = 30;
            person2.DP = "營業部";
            person2.EmpSalary = 52000;            //設定EmpSalary屬性值為16000(小於18780)
                                                  //16000會傳給EmpSalary屬性存取子中
                                                  //set {...} 區塊中的value引數
            person2.ShowInfo();

            Console.Read();
        }
    }
    class Employee
    {
        public string EmpID, EmpName,DP;
        private int _EmpSalary;    //_salary為私有欄位成員
        private int _age;
        public int EmpSalary       // 公開屬性成員
        {
            get
            {
                return _EmpSalary;
            }
            set
            {
                if (value > 40000)
                    value = 40000;  //若value小於18780,則指定value為18780
                _EmpSalary = value;
               // Console.WriteLine($"==== 薪資範圍檢查結果 : _EmpSalary = {_EmpSalary}");
            }
        }
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;  //若value小於18780,則指定value為18780
                    _age = value;
                   // Console.WriteLine($"年齡: {_age}");
                }
                else if (value > 100)
                {
                    value = 100;  //若value小於18780,則指定value為18780
                    _age = value;
                   // Console.WriteLine($"年齡: {_age}");
                }
                else
                {

                    _age = value;
                    Console.WriteLine($"年齡: {_age}");
                }
            }
        }


        public void ShowInfo()	        //定義ShowInfo方法用來顯示產品的編號,姓名,薪資
        {
            Console.WriteLine($"編號：{EmpID}");
            Console.WriteLine($"姓名：{EmpName}");
            Console.WriteLine($"年齡: {age}");
            Console.WriteLine($"部門: {DP}");
            Console.WriteLine($"薪資：{EmpSalary}");  
            Console.WriteLine("============================");
        }
    }

}


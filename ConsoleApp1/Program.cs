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
            car cr=new car();
            cr.name = "bmw";
            cr.color = "black";
            cr.model = "f10";
            cr.brand = "Germany";
            Console.WriteLine("name :"+cr.name);
            Console.WriteLine("color :" + cr.color);
            Console.WriteLine("model :"+cr.model);
            Console.WriteLine("brand :"+cr.brand);
            Console.Read();
        }
    }
}

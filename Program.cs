using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate int delegName(string txt);
        delegate void deleg2(string txt);

        static void Main(string[] args)
        {
            delegName d1 = new delegName(Test.Method1);
            deleg2 d2 = new deleg2(Test.Method2);

            d2("2");
            Console.WriteLine($"TypeOf val is {d1("2").GetType()}");
            
            Console.ReadKey();
        }
    }

    static class Test
    {
        static public int Method1(string val)
        {
            return Convert.ToInt32(val);
        }

        static public void Method2(string val)
        {
            Console.WriteLine($"val = {val}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csamples
{
    class Delegate
    {
        public static int Add(int x,int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public delegate int Mydelegate(int a, int b);

        public static void Main()
        {
            Mydelegate myDelegate = new Mydelegate(Add);
            Mydelegate myDelegate1 = new Mydelegate(Sub);
            int addResult = myDelegate(6, 7);
            int subResult = myDelegate1(6, 7);
            Console.WriteLine(addResult);
            Console.WriteLine(subResult);

        }


    }
}

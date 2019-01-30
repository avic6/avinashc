using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csamples
{

    public class Delegate1
    {
       

        public static void Main()
        {

            // public delegate void NoArgument();
            //  NoArgument _noArgument;
            Action v1;

            //public delegate int ReturnInteger(int x);
            // ReturnInteger _rr;
            Func<int, int> v2;


            // public delegate void ReturnInteger1(int x1, int x2);
            //  ReturnInteger1 _rr1;

            Action<int, int> v3;

            // public delegate string ReturnString1(string x1, string x2);
            //  ReturnString1 _ss1;

            Func<string, string, string> v4;

            // public delegate int ReturnIstring2(string y1);
            //  ReturnIstring2 _ir;


            Func< string,int> v5=delegate (string myString)
            {
                return myString.Length;
            };
            int result = v5("sonata");

            Console.WriteLine(result);

            Func<string, int> v6 = (string myString)=>
            {
                return myString.Length;
            };

       
            int result1 = v6("sonata"); 

           Console.WriteLine(result1);


        }



      /*  static int GetLength(string myString)
        {
            return myString.Length;
        }*/



    }

}

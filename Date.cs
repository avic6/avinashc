using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
[assembly:AssemblyKeyfile(@"d:\myfile.key")]

namespace csamples
{
    class InvalidDateException:ApplicationException
    {
       public InvalidDateException(string message):base(message)
            {

        }
    }



    class Date
    {
        int day, month;
        int year;

        public Date(int a,int b,int c)
        {

            if (a <= 0 || b <= 0 || c <= 0)
                throw new   InvalidDateException("error");
            day = a;
            month = b;
            year = c;

        }
        public int GetDay()
        {
            return day;
        }
        public int GetMonth()
        {
            return month;
        }
        public int GetYear()
        {
            return year;
        }
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
        public override bool Equals(object obj)
        {
            Date d = (Date)obj;
            if (this.day == d.day && this.month == d.month && this.year == d.year)
                return true;
            else
                return false;
            
        }
    }
    class Driver
    {
        public static void Main()
        {
            Date d1 = new Date(10, 12, 0);
            Date d2 = new Date(10, 12, 2015);
            if (d1.Equals(d2)) 
            Console.WriteLine("true");
            else
            Console.WriteLine("false");
        }
    }

}

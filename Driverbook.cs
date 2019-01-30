using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csamples
{
 abstract   class Book
    {

        int id;
        string name;
        protected double price;

        public Book(int eid,string ename,double eprice)
        {
            id = eid;
            name = ename;
            price = eprice;
        }



        public abstract double Discount();
       /* {

            return price * 5 / 100;

        }*/
    }

    class Fiction : Book
    {
      public Fiction(int eid,string ename,int eprice):base( eid,ename,eprice)
        {

        }
        public override double Discount()
        {
            return price * 10 / 100;
        }

    }

    class DriverBook
    {
        public static void Main()
        {
            

            Book b = new Fiction(1, "avinash", 200);
            Console.WriteLine(b.Discount());


        }
    }





}

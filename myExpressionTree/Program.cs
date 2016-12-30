using System;
using System.Linq.Expressions;
namespace myExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Expression<Func<int, int, int>> expression = (a, b) => a + b;
            Console.WriteLine("This is the expression body",expression.Body);
            Console.WriteLine("This is the actual expression",expression);
            //int d = expression(3, 5);
            Func<int, int, int> function = (a, b) => a + b;
            Func<int, int, bool> function2 = (a,b) => (a < b);
           
            Expression<Func<int, int, bool>> Expression2 = (a, b) => (a < b);
            Console.WriteLine("This is expression2's body", Expression2.Body);
            Expression<Func<int, bool>> lessThan = i => i < 5;
            Console.WriteLine(lessThan);
            Console.WriteLine("result of expression of i < 5 = {0}", lessThan);
            Expression<Func<int, int>> plusEquals = (a) =>  (a+a);
            Console.WriteLine("This is plusEqual's body", plusEquals.Body);
            Console.WriteLine(plusEquals);
            //Int32 c = plusEquals(3);
            int c = plusEquals.Compile()(3);
            Console.WriteLine("Here is result of plusEquals expression on c {0}",c);
            //I am trying to do a sql query here 
            var query = from c in db.Customers
                        where c.City == "Nantes"
                        select new { c.City, c.CompanyName };

            Console.ReadLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class solution
    {
        public  void table()
        {
            Console.WriteLine("***using for loop...***"); 
            Console.WriteLine("Enter the number for table ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result;
            for (int i = 0; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine("Result is {0}*{1}={2}",n,i,result);
            }          
        }
        public void table1()
        {
            Console.WriteLine("***using  while loop...***");
            Console.WriteLine("Enter the number for table ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i=0;
            int result;
            while(i<=10)
            {
                result = n * i;
                
               
                Console.WriteLine("\t {0}*{1}={2}",n,i,result);
                i++;
            }
          
        }
        public void table2()
        {
            Console.WriteLine("***using do while loop...***");
            Console.WriteLine("Enter the number for table ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int result;
            do
            {
                result = n * i;
                Console.WriteLine("\t \t{0}*{1}={2}", n, i, result);
                i++;
            } while (i != 10);
        }

     }
}

using System;

namespace LearnAbstractClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Details of FullTime Employee:---");
            FulltimeEmployee fte = new FulltimeEmployee() 
            {
                
                Id = Convert.ToInt32(Console.ReadLine()),
                FirstName= Console.ReadLine(),
                LastName= Console.ReadLine(),
                TotalSalary= Convert.ToInt32(Console.ReadLine()),
            };
             

            Console.WriteLine(fte.getFullName());
            Console.WriteLine(fte.getMonthlySalary());
            Console.WriteLine("Enter Details of ContractEmployee Employee:---");
            ContractEmployee ce = new ContractEmployee()
            {
                Id = Convert.ToInt32(Console.ReadLine()),
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Hours = Convert.ToInt32(Console.ReadLine()),
                HourlySalary = Convert.ToInt32(Console.ReadLine()),

            };

            Console.WriteLine(ce.getFullName());
            Console.WriteLine(ce.getMonthlySalary());
        }
    }
}

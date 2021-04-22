using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAbstractClass
{
    class ContractEmployee:BaseClass
    {
        public int Hours { get; set; }
        public int HourlySalary { get; set; }

        
        public override int getMonthlySalary()
        {
            return this.Hours * HourlySalary;
        }
    }
}

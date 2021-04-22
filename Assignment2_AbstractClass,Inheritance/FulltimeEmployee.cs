using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAbstractClass
{
    class FulltimeEmployee:BaseClass
    {
        
        public int TotalSalary { get; set; }

        
        public override int getMonthlySalary()
        {
            return this.TotalSalary/12;
        }



    }
}

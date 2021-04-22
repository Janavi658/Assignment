using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAbstractClass
{
    public abstract class  BaseClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string getFullName()
        {
            return this.FirstName + " " + LastName;
        }
        public abstract int getMonthlySalary();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationProblem
{
    public class EmpCheck
    {
        public static void CheckEmployee() {
            int Is_full_time = 1;
            Random random= new Random();
            int empcheck = random.Next(2);
            if(empcheck == Is_full_time) {
                Console.WriteLine("Employee is present");
                    }
            else
            {
                Console.WriteLine("employee is not present");
            }
        
        }
    }
}

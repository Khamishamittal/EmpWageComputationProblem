

namespace EmpWageComputationProblem
{
    public class EmpCheck

    {
       public const int Is_full_time = 1;
       public const int Emp_Rate_Per_Hour = 20;
        public const int Is_part_time = 2;
        public static void CheckEmployee()
        {
            

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);
            switch(empcheck)
            {
                case Is_full_time:
                    empHrs = 8;
                    break;
                    case Is_part_time: 
                    empHrs = 4;
                    break;
                default:
                    empHrs= 0; 
                    break;

            }
            
            empWage = empHrs * Emp_Rate_Per_Hour;
         Console.WriteLine("Emp Wage : " + empWage);
                }
    }
}


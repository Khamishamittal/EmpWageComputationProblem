

namespace EmpWageComputationProblem
{
    public class EmpCheck

    {

        public static void CheckEmployee()
        {
            int Is_full_time = 1;
            int Emp_Rate_Per_Hour = 20;
            int Is_part_time = 2;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == Is_full_time)
            {
                empHrs = 8;
            }
            else if (empcheck == Is_part_time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
                empWage= 0;

            }
            empWage = empHrs * Emp_Rate_Per_Hour;
         Console.WriteLine("Emp Wage : " + empWage);
                }
    }
}


﻿

namespace EmpWageComputationProblem
{
    public class EmpCheck

    {
       public const int Is_full_time = 1;
       public const int Emp_Rate_Per_Hour = 20;
        public const int Is_part_time = 2;
        public const int Num_Of_Working_Days = 20;
        public static void CheckEmployee()
        {
            

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < Num_Of_Working_Days; day++)
            {

                Random random = new Random();
                int empcheck = random.Next(3);

                switch (empcheck)
                {
                    case Is_full_time:
                        empHrs = 8;
                        break;
                    case Is_part_time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }

                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empWage;
            }
         Console.WriteLine("Emp Wage : " + empWage);
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
                }
    }
}


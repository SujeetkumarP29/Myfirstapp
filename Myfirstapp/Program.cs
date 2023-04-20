using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstapp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            EmployeeService employeeService = new EmployeeService();
            bool A = true;
            while (A) {
                Console.WriteLine("-------------------------Employee Management system-------------------------");
                Console.WriteLine("                Please Select the choice from Below options                  ");
                Console.WriteLine("                        1.Create Employee\r\n" + "                        2.Show all Employee deatails\r\n"+"                        3.Delete employee \r\n"+"                        4.Exit\r\n");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeService.CreatEmployee();
                        break;
                    case 2:
                        employeeService.ShowAllEmployees();
                        break;
                    case 3:
                        employeeService.DeleteEmployee();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choice.");
                        break;

                }

                Console.ReadLine();
            }
        }
    }
}
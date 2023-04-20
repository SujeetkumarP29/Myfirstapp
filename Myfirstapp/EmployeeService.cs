using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstapp
{
    internal class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();
        
public void CreatEmployee()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee ID:");
            emp.EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation:");
            emp.Empdesignation = Console.ReadLine();
            Console.WriteLine("Enter Employee Department:");
            emp.EmpDepartment = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            emp.EmpSalary = Convert.ToInt32(Console.ReadLine());

            employees.Add(emp);
            Console.WriteLine("EMployee Added Successfully.");
           
        }
        public void ShowAllEmployees()
            {
                if (employees.Count == 0)
                {
                    Console.WriteLine("No employees found");
                }
                else
                {
                    Console.WriteLine("Employee Details:");
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine("ID:{0},Name:{1},Designation:{2},Department:{3},Salary:{4}", employee.EmpID, employee.EmpName, employee.Empdesignation, employee.EmpDepartment, employee.EmpSalary);
                    }
                }



            }
        public void DeleteEmployee()
            {
                Console.WriteLine("Enter the empID");
                int empID=int.Parse(Console.ReadLine());
                
                Employee employee = employees.Find(e => e.EmpID == empID);
                if (employee != null)
                {
                    employees.Remove(employee);
                    Console.WriteLine("Employee deleted successfully");
                }
                else
                {
                    Console.WriteLine("No employee found with ID:{0}.", employee.EmpID);
                }
            }


        }

    }
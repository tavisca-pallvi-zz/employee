using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeDatabase
{
    class Program
    {

        public delegate int MyDelegate();

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int f = 1;
            while (f == 1) {
                Console.WriteLine("Do you want to add employee enter '1' else '0'");


                int check = Int32.Parse(Console.ReadLine());
                if (check == 0) {
                    f = 0;
                    Console.WriteLine("Application Exited");

                    System.Environment.Exit(0);
                    Console.ReadLine();
                    return;
                }

                Employee emp = new Employee();

                Console.WriteLine("Enter the id of employee");
                int id = Int32.Parse(Console.ReadLine());
                emp.Id = id;
                Console.WriteLine("Enter the name of employee");
                string name = Console.ReadLine();
                emp.Name = name;
                Console.WriteLine("Enter the qualification of employee");
                string qual = Console.ReadLine();
                emp.qual = qual;

                employees.Add(emp);

                Console.WriteLine(" employees succesfully added");
                Console.WriteLine("Employee name is {0} \n Employee id is {1} \n Employee qualification is {2}", emp.Name, emp.Id, emp.qual);
                //Properties Used
                MyDelegate obj = new MyDelegate(emp.CheckQualification);
              

                try
                {
                    int q = obj();
                    
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);

                    using (StreamWriter writer = new StreamWriter("C:\\test.txt"))
                    {
                        writer.WriteLine(ex.Message);
                    }

                }

                finally
                {
                    Console.WriteLine("\nExecution of the finally block after an unhandled\n");
                            
                }

            }


            Console.ReadLine();

        }

        
    }

}

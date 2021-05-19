using EmpolyeProject.Project;
using System;
using System.Text;

namespace EmpolyeProject
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Employe emp = new Employe();
            Console.WriteLine("Enter Employe No: ");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employe Name: ");
            emp.name = Console.ReadLine();

            Console.WriteLine("Enter Department Name: ");
            emp.dept = Console.ReadLine();

            Console.WriteLine("Enter Designiation Name:");
            emp.desig = Console.ReadLine();

            Console.WriteLine("Enter Basic Pay: ");
            emp.basics = Convert.ToInt32(Console.ReadLine());

            Validation v = new Validation();

            Console.WriteLine(v.Validate(emp));




            

        }
    }
}

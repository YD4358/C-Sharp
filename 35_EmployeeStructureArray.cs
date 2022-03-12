//Write a C# program to store the information of 5 employees using structure and array.
using System;
namespace Assignments
{
    class EmpStrArr
    {
        struct Employee
        {
            public string name;
            public string Dept;
            public int age;
        }
        public void EmpStr()
        {
            Employee [] emp={new Employee(),new Employee(),new Employee(),new Employee(),new Employee()};
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter details for Emp no.{0}",(i+1));
                Console.Write("Employee Name: ");
                emp[i].name = Console.ReadLine();
                Console.Write("Employee Department: ");
                emp[i].Dept = Console.ReadLine();
                Console.Write("Employee age: ");
                emp[i].age = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Stored Employee Details are: \n");
            for (int j=0;j<5;j++)
                Console.WriteLine((j+1)+". "+emp[j].name+"\t"+emp[j].Dept+"\t"+emp[j].age);
        }
    }
}
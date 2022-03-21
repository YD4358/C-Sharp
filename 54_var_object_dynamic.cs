//Demonstrate the difference between var, object and dynamic data types with suitable example.
using System;
namespace Assignments
{
    class varObjDyn
    {
        public void diff()
        {
            var a = "Implicitly Typed Local Variables var";
            dynamic b = true;
            object c = 0.1f;

            Console.WriteLine("var is used as Implicitly Typed Local Variables. Here var is used as => {0} ", a.GetType());
            Console.WriteLine("Dynamic is used to avoid the compile-time type checking. The compiler gets the type at the run time. Here Dynamic is used as => {0}",b.GetType());
            Console.WriteLine("Object can hold the reference of instance of any type. Here object has the reference of => {0}",c.GetType());
        }
    }
}
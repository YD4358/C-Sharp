/*Create a file which includes only data members, another file which contains all constructors of the class, 
  another file which will include all functions related. Use the concept of partial class.*/
using System;
//----------------------------FILE 1--------------------------//
namespace Assignments
{
	partial class partt
	{
		dynamic a,b;
	}
}
//----------------------------FILE 2--------------------------//
namespace Assignments
{
	partial class partt
	{
		internal partt()
		{
			System.Console.WriteLine("Default Constructor");
		}
		internal partt(int a)
		{
			System.Console.WriteLine(a+" Parameter Constructor");
		}
		internal partt(partt a)
		{
			System.Console.WriteLine("Copy Constructor");
		}
	}
}
//----------------------------FILE 3--------------------------//
namespace Assignments
{
	partial class partt
	{
		internal void funcc()
		{
			System.Console.WriteLine("Inside Function");
		}
	}
}
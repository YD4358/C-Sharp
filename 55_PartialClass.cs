//Write a program which will implement the partial class concept.
using System;
namespace Assignments
{
	partial class part
	{
		int a=10;
	}
	partial class part
	{
		internal void function()
		{
			System.Console.WriteLine("Inside Function");
		}
	}
	partial class part
	{
		internal part(out int c)
		{
			c = a;
		}
	}
}
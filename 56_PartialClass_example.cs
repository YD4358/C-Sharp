/*Create a file which includes only data members, another file which contains all constructors of the class, 
  another file which will include all functions related. Use the concept of partial class.*/
using System;
namespace Assignments
{
	partial class part
	{
		dynamic a,b;
	}
	partial class part
	{
		internal part(out int c)
		{
			c = a+b;
		}
	}
}
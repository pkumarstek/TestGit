using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			object obj1 = "";
			//object obj = obj1.GetType();

			//if(obj.Equals(null))
			//{
			//	Console.WriteLine("null");
			//}
			//else if(obj.Equals(typeof(string)))
			//{
			//	Console.WriteLine("string");
			//}
			//else if(obj.Equals(typeof(short)) || obj.Equals(typeof(int)) || obj.Equals(typeof(decimal)) || obj.Equals(typeof(Single)) || obj.Equals(typeof(double)))
			//{
			//	Console.WriteLine("number");
			//}
			//else if(obj.Equals(typeof(DateTime)))
			//{
			//	Console.WriteLine("Datetime");
			//}

			string val = "";
			if(Convert.ToBoolean(val = "false"))
			{
				Console.WriteLine("inside if condition");
			}

			Console.ReadLine();
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack myStack = new Stack();

			myStack.Push("Pocket");
			myStack.Push("Sherm");
			myStack.Push("Wolfie");
			myStack.Push("Josh");
			myStack.Push("Craig");

			foreach(string names in myStack) {
				Console.WriteLine(names);
			}
			Console.ReadKey();
		}
	}
}

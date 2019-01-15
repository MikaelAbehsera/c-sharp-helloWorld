using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Imagine a small child ascending a staircase that has `n` steps.The child can hop either 1, 2, or 3 steps at a time.Implement a function `climbing_stairs` that counts the number of possible ways in which the child can ascend the staircase.

//For example, for a staircase with `n = 3` (the stair has 3 steps), there are 4 possible ways for the child to ascend the staircase:

// 1. They can jump 3 hops of 1 step
// 2. They can go up 1 step, followed by a jump of 2 steps
// 3. They can jump up 2 steps, then go up the last step
// 4. They can make a single jump of 3 steps

//Thus, `climbing_stairs(3)` should return an answer of 4.

//Things he forgot: 
// - must be done recursivly 
// 

// Examples: 
// - 10 => 274
// - 8 => 127
// - 5 => 17
// - 

namespace patrickThing
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.ReadKey();
		}
	}
}

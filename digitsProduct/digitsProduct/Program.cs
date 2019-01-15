using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitsProduct
{ 
	class Program
	{
		/// <summary>
		/// Checks if number is prime.
		/// </summary>
		/// <param name="number">any number in the int range</param>
		/// <returns>returns a boolean</returns>
		static bool isPrime(int number)
		{
			if(number == 1) return false;
			if(number == 2) return true;

			var limit = Math.Ceiling(Math.Sqrt(number));

			for(int i = 2; i <= limit; i++)
			{
				if(number % i == 0) return false;
			}
			return true;
		}

		/// <summary>
		/// Function returns enum with all factors in list form.
		/// </summary>
		/// <param name="number">Any number in the int range</param>
		/// <returns></returns>
		static IEnumerable<int> GetFactors(int n)
		{
			return from a in Enumerable.Range(1, n)
				   where n % a == 0
				   select a;
		}

		/// <summary>
		/// returns the smallest positive integer the product of whose digits is equal to product.
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		static int digitsProduct(int product)
		{
			if(!isPrime(product))
			{
				if(product % 2 == 0)
				{

				}
				else if(product == 1)
				{
					return 1;
				}
				else if(product == 0)
				{
					return 0;
				}
			}
			return -1;
		}

		static void Main(string[] args)
		{
			digitsProduct(12);
		}
	}
}

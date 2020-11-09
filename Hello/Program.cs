using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
	class Program
	{
		//Function to find multiply of 3 from 200 to 1
		static void multipliers() {
			int a = 3;
			for (int i = 200; i >= 1; i--) {
				if (i % a==0) { Console.WriteLine(i); }
				
			}
		}

		//function to write numbers in A single loop from 1 -10- 1
		static void numberPrint() {
			int a = 1;
			int check = 10;
			int j;
			for ( j = 1; j >=0; j+= a) {

				if (j == check) { a =-a; }
				console.writeline(j);

			}
		}

		//Duplicate findings
		static void duplicate(int[] a) {
			for (int i = 0; i < a.Length-1; i++) {
				for (int j = 1; j <= a.Length; j++) {
					if (j == i) {
						Console.Write(j);
					}
				}
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//String reverse problem
			/*Console.WriteLine("please give your string");
			String str = Console.ReadLine();

			for (int i = str.Length - 1; i >= 0; i--) {
				Console.Write(str[i]);
			}*/

			Console.WriteLine("please enter array size");
			int n = Convert.ToInt32 (Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++) {
				Console.WriteLine("please give number");
				a[i] = Convert.ToInt32(Console.ReadLine());
			}


			//Program.multipliers();
			//Program.numberPrint();
			//Program.forPrint();
			Program.duplicate(a);



			Console.ReadLine();
		}
	}
}

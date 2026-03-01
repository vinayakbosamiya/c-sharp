using System;

namespace vinay
{
	public class Emp
	{
		private int id;
		private string name;
		private int age;

		public void accept(int i, string n, int a)
		{
			id = i;
			name = n;
			age = a;
		}

		public void display()
		{
			// // below both syntax work
			//Console.WriteLine("Id " + id + " Name " + name + " Age " + age);
			Console.WriteLine("Id {0}, Name {1} and Age {2}", id, name, age);
		}
	}
}
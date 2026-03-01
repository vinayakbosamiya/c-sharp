using System;
namespace stud
{

public class student
{
		static public void s()
		{
			Console.WriteLine("i am static class");
		}
		public int r,f;
		public void set(int r,int f)
		{
			this.r = r;
			this.f = f;
		}

		public void display()
		{
			Console.WriteLine("the roll no: {0} and fees: {1}",r,f);
		}
}

}
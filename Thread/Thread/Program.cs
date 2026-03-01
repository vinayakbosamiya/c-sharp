using System;
using System.Threading;
namespace PracticeApp
{
	class practice{
		
	void Display()
	{
			for (int i = 0; i < 10; i++) { 
			Console.WriteLine("Process " + i);
			Thread.Sleep(1000);
			}
	}
		void Display1()
		{
			for (int i = 0; i < 15; i++)
			{
				Console.WriteLine("Process " + i);
				Thread.Sleep(1000);
			}
		}

		static void Main(string[] args) {
			practice p = new practice();
			// ThreadStart th = new ThreadStart(p.Display);
			ThreadStart th = p.Display; // this is the delegates
			Thread t = new Thread(th);
				t.Start();
			
			t.Join();// this join method is wait for current Thread will not complete. // it means first of all complete the first thread and after start second thread

			ThreadStart thh = p.Display1;// this is the delegates
			Thread tt = new Thread(thh);
			tt.Start();
		}
}
}
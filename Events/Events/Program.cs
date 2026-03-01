using System;
namespace practiceapp
{
	class EvenDemo
	{
		public delegate void EventHandler();
		public event EventHandler MyEvent
		{
			add
			{
				Console.WriteLine("add operation");
			}

			remove
			{
				Console.WriteLine("remove operation");
			}
		}
		private void testEvent()
		{
			Console.WriteLine("Event Fired!");
		}
		public void Test()
		{
			EvenDemo e = new EvenDemo();
			e.MyEvent += testEvent;
			//e.MyEvent -= testEvent;
		}

		
		static void Main(string[] args)
		{
			EvenDemo ee = new EvenDemo();
			ee.Test();
		}
	}
}
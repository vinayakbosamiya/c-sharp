namespace practiceapp
{

	class Program
	{
		class hello
		{

			public delegate void helloHandler();
			public void welcom()
			{
				Console.WriteLine("Hello And Welcome To C# and .Net");
			}
		}
		static void Main(string[] args)
		{
			hello h = new hello();
			hello.helloHandler wh = new hello.helloHandler(h.welcom);
			wh();
		}
	}
}
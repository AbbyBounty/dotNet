using System;

namespace BoxingAndUnboxing {
	class MainClass {
		public static void Main (string [] args)
		{
			int count = 45;
			Console.WriteLine (count);

			Object o= count;
			Console.WriteLine (o);

			int result =(int) o;
			Console.WriteLine (result);


		}
	}
}

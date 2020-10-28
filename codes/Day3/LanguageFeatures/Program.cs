using System;

namespace LanguageFeatures {

	abstract public class Shape {

		abstract public void Draw ();
		 public string Color { get; set; }
		 public string Width { get; set; }
		 public void Display ()
		{
			Console.WriteLine ("shape is getting displayed...");
		}

	}


	public class Line:Shape {

		public override void Draw ()
		{
			Console.WriteLine ("Line is drawn...");
			Console.WriteLine ("First Point {0},{1}");

		}
	}


	interface Iprintable {
		void start ();

		void print ();
		void stop ();
	}

	class ThreeDPrinter : Iprintable {
		public  void start ()
		{
			Console.WriteLine ("printer started");

		}


		void Iprintable.print ()
		{
			Console.WriteLine ("printer printing..");
		}


		public void stop ()
		{
			Console.WriteLine ("printer stopped");

		}
	}

	class MainClass {
		public static void Main (string [] args)
		{

			int num = 12;
			float price = 40.5f;
			bool flag = false;
			double score = 5600;
			MainClass mainClass = new MainClass ();

			Iprintable iprintable = null;


			ThreeDPrinter threeDPrinter = new ThreeDPrinter ();
			iprintable = threeDPrinter;
			iprintable.start ();
			iprintable.print ();
			iprintable.stop ();



			Line line = new Line ();
			line.Display ();
			line.Draw ();


		}
	}
}

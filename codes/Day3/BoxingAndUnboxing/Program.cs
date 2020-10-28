using System;
using HR;
using System.Collections.Generic;
namespace BoxingAndUnboxing {


	class MyMathClass {

		public const int countDown= 56;
		public  readonly double PI;
		 MyMathClass ()
		{
			PI = 3.14;
		}
	}

	

	class MainClass {
		public static void Main (string [] args)
		{
			//int count = 45;
			//Console.WriteLine (count);

			//Object o = count;
			//Console.WriteLine (o);

			//int result = (int)o;
			//Console.WriteLine (result);


			//List<Person[]> persons = new List<Person[]> ();

			
			//persons.Add (new Person ("Ravi", "Tambade", new DateTime (1999, 03, 01)));
			//persons.Add (new Person ("Sameer", "Nene", new DateTime (1995, 03, 8)));
			//persons.Add (new Person ("Rajiv", "Gu[ta", new DateTime (1993, 03, 8)));


			//foreach(Person person in persons) {
			//	Console.WriteLine (person);
			//}




			//List<String> l1 = new List<String> ();
			//l1.Add ("1");
			//l1.Add ("2");

			//List<String> l2 = new List<String> ();
			//l2.Add ("3");
			//l2.Add ("4");
			//l2.Add ("5");

			//List<String> [] arrayOfList = new List<String>[2];
			//arrayOfList [0] = l1;
			//arrayOfList [1] = l2;

			

			//for (int i = 0; i < arrayOfList.Length; i++) {
			//	List<String> l = arrayOfList [i];
			//	foreach(string srtinglist in l) {
			//	Console.WriteLine (srtinglist);

			//	}
			//}


			List<Person> persons1 = new List<Person> ();
			persons1.Add (new Person ("steve", "Jobs", new DateTime (1999, 03, 01)));
			persons1.Add (new Person ("Will", "Smith", new DateTime (1999, 03, 01)));

			List<Person> persons2 = new List<Person> ();
			persons2.Add (new Person ("Jack", "Jill", new DateTime (1999, 03, 01)));
			persons2.Add (new Person ("Rayn", "Steven", new DateTime (1999, 03, 01)));
			persons2.Add (new Person ("Tim", "Cook", new DateTime (1999, 03, 01)));

			List<Person> [] arrayOfListPerson = new List<Person> [2];
			arrayOfListPerson [0] = persons1;
			arrayOfListPerson [1] = persons2;



			for (int i = 0; i < arrayOfListPerson.Length; i++) {

				List<Person> persons = arrayOfListPerson [i];
				foreach (Person person in persons) {
					Console.WriteLine (person);

				}
			}
			

		}
	}
}

using System;
using Person;
namespace Person {
	public class Person {
		public int id;
		public string name;

		public static Person _ref = null;

		private Person ()
		{

		}

		public static Person GetPerson ()
		{
			if (_ref == null) {
				_ref = new Person ();
				return _ref;
			} else {
				return _ref;
			}
		}


		private Person (int id, string name)
		{
			this.id = id;
			this.name = name;
		}


		public override string ToString ()
		{
			return this.id + " " + this.name;

		}

	}
}

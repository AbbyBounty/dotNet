using System;
namespace OrderProcessing {

	interface IorderService {
		public void Process ();
		public void Cancle ();
		public void getOrder ();
		public void updateOrder ();
		public void createOrder ();
		public void Approve ();

	}
}

using System;
using NServiceBus;
using Amazon.Contracts.Sales;


namespace Amazon.Emailing
{
    public partial class OrderSubmittedProcessor : IHandleMessages<OrderSubmitted>
    {
		
		public void Handle(OrderSubmitted message)
		{
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(OrderSubmitted message);

		public IBus Bus { get; set; }

    }
}

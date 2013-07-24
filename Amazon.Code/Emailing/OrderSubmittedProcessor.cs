using System;
using NServiceBus;
using Amazon.Contracts.Sales;


namespace Amazon.Emailing
{
    public partial class OrderSubmittedProcessor
    {
		
        partial void HandleImplementation(OrderSubmitted message)
        {
            // Implement your handler logic here.
            Console.WriteLine("Emailing received " + message.GetType().Name);
        }

    }
}

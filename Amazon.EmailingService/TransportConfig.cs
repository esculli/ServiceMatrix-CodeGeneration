using System;
using NServiceBus;
 
namespace Amazon.EmailingService
{
	public class TransportConfig : INeedInitialization
	{
		public void Init()
		{
			// Tranport: Msmq (Default) - No configuration needed
		}
	}
}

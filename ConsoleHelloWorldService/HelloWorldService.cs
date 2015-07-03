using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CServiceStack.ServiceHost;
using CServiceStack.Common.Types;

namespace ConsoleHelloWorldService
{
    public class HelloWorldService : IHelloWorldService
    {
        [Route("/sayHello")]
        public HelloResponseType Hello(HelloRequestType helloWorldIn)
        {
            return new HelloResponseType { Result = "Hello " + helloWorldIn.Name };
        }

        [Route("/check")]
        public CheckHealthResponseType CheckHealth(CheckHealthRequestType healthCheckIn)
        {
            return new CheckHealthResponseType();
        }
    }
}

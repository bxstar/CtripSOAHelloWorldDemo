using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using CServiceStack.Common.Types;

namespace ConsoleHelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = HelloWorldServiceClient.GetInstance("http://localhost:1337");
            var response = client.Hello(new HelloRequestType { Name = "World" });

            if (response.ResponseStatus.Ack == AckCodeType.Success)
            {
                Console.WriteLine("Response : {0}", response.Result);
            }
            else
            {
                Console.WriteLine("Error : {0}", response.ResponseStatus.Errors[0].Message);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CServiceStack.ServiceHost;
using CServiceStack.Common.Types;

namespace ConsoleHelloWorldService
{
    /// <summary>
    /// SOA的实现（Route为Resful方式调用）
    /// </summary>
    public class HelloWorldServiceImp : IHelloWorldService
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

        #region IHelloWorldService Members


        public GetLatestTimeResponseType GetLatestTime(GetLatestTimeType request)
        {
            string strDtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("accept client request at " + strDtNow);
            return new GetLatestTimeResponseType { Result = strDtNow };
        }

        public AddNumberResponseType AddNumber(AddNumberRequestType request)
        {
            int result = request.num1 + request.num2;
            return new AddNumberResponseType { Result = result };
        }

        #endregion
    }
}

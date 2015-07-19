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
            var client = HelloWorldServiceClient.GetInstance("http://localhost:13337");
            
            
            //var response = client.Hello(new HelloRequestType { Name = "World" });

            //if (response.ResponseStatus.Ack == AckCodeType.Success)
            //{
            //    Console.WriteLine("Response : {0}", response.Result);
            //}
            //else
            //{
            //    Console.WriteLine("Error : {0}", response.ResponseStatus.Errors[0].Message);
            //}

            ////新加的方法，返回服务器当前的时间
            //int i = 1;
            //while (i++ < 20)
            //{
            //    System.Threading.Thread.Sleep(1000);

            //    var latestResponse = client.GetLatestTime(new GetLatestTimeType());
            //    if (latestResponse.ResponseStatus.Ack == AckCodeType.Success)
            //    {
            //        Console.WriteLine(latestResponse.Result);
            //    }
            //}
            
            ////工具生成的方法，计算数字之和
            //int n1 = 10; int n2 = 5;
            //var addResponse = client.AddNumber(new AddNumberRequestType { num1 = n1, num2 = n2 });

            //Console.WriteLine(addResponse.Result);

            //int n1 = 20;
            //PersonModel p = new PersonModel() { Name = "yrs", Age = 30 };
            //var personResponse = client.AddPersonAge(new AddPersonAgeRequestType { num1 = n1, Person = p });
            
            //Console.WriteLine(personResponse.IsPersonOlder);
            //Console.WriteLine(personResponse.Person.Name);

            //int n2 = 31;
            //PersonModel p2 = new PersonModel() { Name = "yrs", Age = 30 };
            //var personResponse2 = client.AddPersonAge(new AddPersonAgeRequestType { num1 = n2, Person = p2 });

            //Console.WriteLine(personResponse2.IsPersonOlder);
            //Console.WriteLine(personResponse2.Person.Name);


            int i = 3;
            var response4 = client.GetAllPerson(new GetAllPersonRequestType { num1 = i });
            Console.WriteLine(response4.Result);

            foreach (var item in response4.PersonList)
            {
                Console.WriteLine(item.Name+"\t"+item.Age);
            }

            Console.ReadKey();
        }
    }
}

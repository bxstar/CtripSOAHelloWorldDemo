using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleHelloWorldService.Entity;

namespace ConsoleHelloWorldService.InterfaceDefine
{
    /// <summary>
    /// HelloWorld接口定义
    /// </summary>
    public interface IHelloWorldServiceDefine
    {
        PersonEntity SavePerson(PersonEntity p); 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleHelloWorldService.Entity
{
    /// <summary>
    /// 人员基础信息
    /// </summary>
    public class PersonEntity
    {
        /// <summary>
        /// 人员ID，唯一标识
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 人员年龄
        /// </summary>
        public int Age { get; set; }
    }
}

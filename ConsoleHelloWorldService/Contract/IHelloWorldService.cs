﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleHelloWorldService
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using CServiceStack.ProtoBuf;
    using CServiceStack.ServiceHost;
    using CServiceStack.Common.Types;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("HelloRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="HelloRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class HelloRequestType
    {
        
        private string nameField;
        
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("HelloResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="HelloResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class HelloResponseType : IHasResponseStatus
    {
        
        private ResponseStatusType responseStatusField;
        
        private string resultField;
        
        [DataMember()]
        [ProtoMember(1)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public string Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetLatestTimeRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="GetLatestTimeRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class GetLatestTimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetLatestTimeResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="GetLatestTimeResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class GetLatestTimeResponseType : IHasResponseStatus
    {
        
        private ResponseStatusType responseStatusField;
        
        private string resultField;
        
        [DataMember()]
        [ProtoMember(1)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public string Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("AddNumberRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="AddNumberRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class AddNumberRequestType
    {
        
        private int num1Field;
        
        private int num2Field;
        
        [DataMember()]
        [ProtoMember(1)]
        public int num1
        {
            get
            {
                return this.num1Field;
            }
            set
            {
                this.num1Field = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public int num2
        {
            get
            {
                return this.num2Field;
            }
            set
            {
                this.num2Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("AddNumberResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="AddNumberResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class AddNumberResponseType : IHasResponseStatus
    {
        
        private ResponseStatusType responseStatusField;
        
        private int resultField;
        
        [DataMember()]
        [ProtoMember(1)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public int Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("AddPersonAgeRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="AddPersonAgeRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class AddPersonAgeRequestType
    {
        
        private int num1Field;
        
        private PersonModel personField;
        
        [DataMember()]
        [ProtoMember(1)]
        public int num1
        {
            get
            {
                return this.num1Field;
            }
            set
            {
                this.num1Field = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public PersonModel Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=true)]
    [DataContract(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class PersonModel
    {
        
        private string nameField;
        
        private int ageField;
        
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public int Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("AddPersonAgeResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="AddPersonAgeResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class AddPersonAgeResponseType : IHasResponseStatus
    {
        
        private ResponseStatusType responseStatusField;
        
        private bool isPersonOlderField;
        
        private PersonModel personField;
        
        [DataMember()]
        [ProtoMember(1)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public bool IsPersonOlder
        {
            get
            {
                return this.isPersonOlderField;
            }
            set
            {
                this.isPersonOlderField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(3)]
        public PersonModel Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("SavePersonListRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="SavePersonListRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class SavePersonListRequestType
    {
        
        private List<PersonModel> personListField;
        
        [System.Xml.Serialization.XmlElementAttribute("PersonList")]
        [DataMember()]
        [ProtoMember(1)]
        public List<PersonModel> PersonList
        {
            get
            {
                if ((this.personListField == null))
                {
                    this.personListField = new List<PersonModel>();
                }
                return this.personListField;
            }
            set
            {
                this.personListField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("SavePersonListResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [DataContract(Name="SavePersonListResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [ProtoContract()]
    public partial class SavePersonListResponseType : IHasResponseStatus
    {
        
        private ResponseStatusType responseStatusField;
        
        private decimal avgAgeField;
        
        private List<PersonModel> personListField;
        
        [DataMember()]
        [ProtoMember(1)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        [DataMember()]
        [ProtoMember(2)]
        public decimal AvgAge
        {
            get
            {
                return this.avgAgeField;
            }
            set
            {
                this.avgAgeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PersonList")]
        [DataMember()]
        [ProtoMember(3)]
        public List<PersonModel> PersonList
        {
            get
            {
                if ((this.personListField == null))
                {
                    this.personListField = new List<PersonModel>();
                }
                return this.personListField;
            }
            set
            {
                this.personListField = value;
            }
        }
    }
    
    /// <summary>
    /// Service interface auto-generated by SOA tool, DO NOT CHANGE!
    /// 
    /// 注意，实现该接口的服务在CServiceStack服务容器中是以new instance per request的形式被初始化的，
    /// 也就是说，容器会为每个请求创建一个新的服务实例，并在请求结束时释放(release)，而不是单个
    /// 服务实例(singleton)服务所有的请求, 所以请务必不要在服务初始化（例如构造函数中）时做较重的初始化
    /// （例如初始化数据库等）动作，否则对性能有很大影响，如果有较重的初始化动作，
    /// 请在服务实现中以静态方式（例如静态构造函数中)一次性完成，或者以IoC注入方式初始化，在服务容器
    /// 启动时事先将依赖初始化并注册在容器中，让容器在构造服务实例时自动解析和注入依赖(也可在服务实现中手动解析依赖)，
    /// 关于静态和依赖注入初始化的样例，请参考CServiceStack提供的样例程序.
    /// 
    /// 
    /// </summary>
    [CServiceInterface("HelloWorldService", "http://soa.ctrip.com/activity/booking/openapi/v1", "2.0.3.2")]
    public interface IHelloWorldService
    {
        
        CheckHealthResponseType CheckHealth(CheckHealthRequestType request);
        
        HelloResponseType Hello(HelloRequestType request);
        
        GetLatestTimeResponseType GetLatestTime(GetLatestTimeType request);
        
        AddNumberResponseType AddNumber(AddNumberRequestType request);
        
        AddPersonAgeResponseType AddPersonAge(AddPersonAgeRequestType request);
        
        SavePersonListResponseType SavePersonList(SavePersonListRequestType request);
    }
}

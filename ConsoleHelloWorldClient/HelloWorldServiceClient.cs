﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleHelloWorldClient
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
    using System.Threading;
    using System.Threading.Tasks;
    using CServiceStack.ServiceHost;
    using CServiceStack.ServiceClient;
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
        public PersonModel person
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
    
    /// <summary>
    /// Service client auto-generated by SOA tool, DO NOT CHANGE!
    /// 
    /// 
    /// </summary>
    public class HelloWorldServiceClient : ServiceClientBase<HelloWorldServiceClient>
    {
        
        public const string CodeGeneratorVersion = "2.0.3.2";
        
        public const string OriginalServiceName = "HelloWorldService";
        
        public const string OriginalServiceNamespace = "http://soa.ctrip.com/activity/booking/openapi/v1";
        
        private HelloWorldServiceClient(string baseUri) : 
                base(baseUri)
        {
        }
        
        private HelloWorldServiceClient(string serviceName, string serviceNamespace, string subEnv) : 
                base(serviceName, serviceNamespace, subEnv)
        {
        }
        
        public virtual CheckHealthResponseType CheckHealth(CheckHealthRequestType checkHealthIn)
        {
            return base.Invoke<CheckHealthResponseType>("CheckHealth", checkHealthIn);
        }
        
        public virtual Task<CheckHealthResponseType> CreateAsyncTaskOfCheckHealth(CheckHealthRequestType checkHealthIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<CheckHealthRequestType, CheckHealthResponseType>("CheckHealth", checkHealthIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<CheckHealthResponseType> StartIOCPTaskOfCheckHealth(CheckHealthRequestType checkHealthIn)
        {
            return base.StartIOCPTask<CheckHealthResponseType>("CheckHealth", checkHealthIn);
        }
        
        public virtual HelloResponseType Hello(HelloRequestType helloIn)
        {
            return base.Invoke<HelloResponseType>("Hello", helloIn);
        }
        
        public virtual Task<HelloResponseType> CreateAsyncTaskOfHello(HelloRequestType helloIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<HelloRequestType, HelloResponseType>("Hello", helloIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<HelloResponseType> StartIOCPTaskOfHello(HelloRequestType helloIn)
        {
            return base.StartIOCPTask<HelloResponseType>("Hello", helloIn);
        }
        
        public virtual GetLatestTimeResponseType GetLatestTime(GetLatestTimeType getLatestTimeIn)
        {
            return base.Invoke<GetLatestTimeResponseType>("GetLatestTime", getLatestTimeIn);
        }
        
        public virtual Task<GetLatestTimeResponseType> CreateAsyncTaskOfGetLatestTime(GetLatestTimeType getLatestTimeIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<GetLatestTimeType, GetLatestTimeResponseType>("GetLatestTime", getLatestTimeIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<GetLatestTimeResponseType> StartIOCPTaskOfGetLatestTime(GetLatestTimeType getLatestTimeIn)
        {
            return base.StartIOCPTask<GetLatestTimeResponseType>("GetLatestTime", getLatestTimeIn);
        }
        
        public virtual AddNumberResponseType AddNumber(AddNumberRequestType addNumberIn)
        {
            return base.Invoke<AddNumberResponseType>("AddNumber", addNumberIn);
        }
        
        public virtual Task<AddNumberResponseType> CreateAsyncTaskOfAddNumber(AddNumberRequestType addNumberIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<AddNumberRequestType, AddNumberResponseType>("AddNumber", addNumberIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<AddNumberResponseType> StartIOCPTaskOfAddNumber(AddNumberRequestType addNumberIn)
        {
            return base.StartIOCPTask<AddNumberResponseType>("AddNumber", addNumberIn);
        }
        
        public virtual AddPersonAgeResponseType AddPersonAge(AddPersonAgeRequestType addPersonAgeIn)
        {
            return base.Invoke<AddPersonAgeResponseType>("AddPersonAge", addPersonAgeIn);
        }
        
        public virtual Task<AddPersonAgeResponseType> CreateAsyncTaskOfAddPersonAge(AddPersonAgeRequestType addPersonAgeIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<AddPersonAgeRequestType, AddPersonAgeResponseType>("AddPersonAge", addPersonAgeIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<AddPersonAgeResponseType> StartIOCPTaskOfAddPersonAge(AddPersonAgeRequestType addPersonAgeIn)
        {
            return base.StartIOCPTask<AddPersonAgeResponseType>("AddPersonAge", addPersonAgeIn);
        }
    }
}

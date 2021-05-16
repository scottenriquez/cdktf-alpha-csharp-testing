using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsMqBroker), fullyQualifiedName: "aws.DataAwsMqBroker", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.DataAwsMqBrokerConfig\"}}]")]
    public class DataAwsMqBroker : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsMqBroker(Constructs.Construct scope, string id, aws.IDataAwsMqBrokerConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBroker(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBroker(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "configuration", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsMqBrokerConfiguration\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsMqBrokerConfiguration Configuration(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsMqBrokerConfiguration>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "encryptionOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsMqBrokerEncryptionOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsMqBrokerEncryptionOptions EncryptionOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsMqBrokerEncryptionOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "instances", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsMqBrokerInstances\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsMqBrokerInstances Instances(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsMqBrokerInstances>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "maintenanceWindowStartTime", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsMqBrokerMaintenanceWindowStartTime\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsMqBrokerMaintenanceWindowStartTime MaintenanceWindowStartTime(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsMqBrokerMaintenanceWindowStartTime>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetBrokerId")]
        public virtual void ResetBrokerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrokerName")]
        public virtual void ResetBrokerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "user", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsMqBrokerUser\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsMqBrokerUser User(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsMqBrokerUser>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AutoMinorVersionUpgrade
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool PubliclyAccessible
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsMqBrokerLogs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsMqBrokerLogs[]? LogsInput
        {
            get => GetInstanceProperty<aws.IDataAwsMqBrokerLogs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsMqBrokerLogs\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsMqBrokerLogs[] Logs
        {
            get => GetInstanceProperty<aws.IDataAwsMqBrokerLogs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

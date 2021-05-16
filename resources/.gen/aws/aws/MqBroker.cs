using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.MqBroker), fullyQualifiedName: "aws.MqBroker", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.MqBrokerConfig\"}}]")]
    public class MqBroker : HashiCorp.Cdktf.TerraformResource
    {
        public MqBroker(Constructs.Construct scope, string id, aws.IMqBrokerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MqBroker(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MqBroker(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "instances", returnsJson: "{\"type\":{\"fqn\":\"aws.MqBrokerInstances\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.MqBrokerInstances Instances(string index)
        {
            return InvokeInstanceMethod<aws.MqBrokerInstances>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetApplyImmediately")]
        public virtual void ResetApplyImmediately()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoMinorVersionUpgrade")]
        public virtual void ResetAutoMinorVersionUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMode")]
        public virtual void ResetDeploymentMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionOptions")]
        public virtual void ResetEncryptionOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogs")]
        public virtual void ResetLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowStartTime")]
        public virtual void ResetMaintenanceWindowStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPubliclyAccessible")]
        public virtual void ResetPubliclyAccessible()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetIds")]
        public virtual void ResetSubnetIds()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInstanceTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerUser\"},\"kind\":\"array\"}}")]
        public virtual aws.IMqBrokerUser[] UserInput
        {
            get => GetInstanceProperty<aws.IMqBrokerUser[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyImmediatelyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ApplyImmediatelyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgradeInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AutoMinorVersionUpgradeInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMqBrokerConfiguration[]? ConfigurationInput
        {
            get => GetInstanceProperty<aws.IMqBrokerConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerEncryptionOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMqBrokerEncryptionOptions[]? EncryptionOptionsInput
        {
            get => GetInstanceProperty<aws.IMqBrokerEncryptionOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerLogs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMqBrokerLogs[]? LogsInput
        {
            get => GetInstanceProperty<aws.IMqBrokerLogs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowStartTimeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerMaintenanceWindowStartTime\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMqBrokerMaintenanceWindowStartTime[]? MaintenanceWindowStartTimeInput
        {
            get => GetInstanceProperty<aws.IMqBrokerMaintenanceWindowStartTime[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessibleInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? PubliclyAccessibleInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "applyImmediately", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ApplyImmediately
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AutoMinorVersionUpgrade
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IMqBrokerConfiguration[] Configuration
        {
            get => GetInstanceProperty<aws.IMqBrokerConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerEncryptionOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IMqBrokerEncryptionOptions[] EncryptionOptions
        {
            get => GetInstanceProperty<aws.IMqBrokerEncryptionOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerLogs\"},\"kind\":\"array\"}}")]
        public virtual aws.IMqBrokerLogs[] Logs
        {
            get => GetInstanceProperty<aws.IMqBrokerLogs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerMaintenanceWindowStartTime\"},\"kind\":\"array\"}}")]
        public virtual aws.IMqBrokerMaintenanceWindowStartTime[] MaintenanceWindowStartTime
        {
            get => GetInstanceProperty<aws.IMqBrokerMaintenanceWindowStartTime[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool PubliclyAccessible
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerUser\"},\"kind\":\"array\"}}")]
        public virtual aws.IMqBrokerUser[] User
        {
            get => GetInstanceProperty<aws.IMqBrokerUser[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}

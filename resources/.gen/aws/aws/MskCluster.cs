using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.MskCluster), fullyQualifiedName: "aws.MskCluster", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.MskClusterConfig\"}}]")]
    public class MskCluster : HashiCorp.Cdktf.TerraformResource
    {
        public MskCluster(Constructs.Construct scope, string id, aws.IMskClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClientAuthentication")]
        public virtual void ResetClientAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationInfo")]
        public virtual void ResetConfigurationInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionInfo")]
        public virtual void ResetEncryptionInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnhancedMonitoring")]
        public virtual void ResetEnhancedMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingInfo")]
        public virtual void ResetLoggingInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenMonitoring")]
        public virtual void ResetOpenMonitoring()
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

        [JsiiProperty(name: "bootstrapBrokers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokers
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerNodeGroupInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterBrokerNodeGroupInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterBrokerNodeGroupInfo[] BrokerNodeGroupInfoInput
        {
            get => GetInstanceProperty<aws.IMskClusterBrokerNodeGroupInfo[]>()!;
        }

        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaVersionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaVersionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberOfBrokerNodesInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBrokerNodesInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "zookeeperConnectString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZookeeperConnectString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAuthenticationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthentication\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMskClusterClientAuthentication[]? ClientAuthenticationInput
        {
            get => GetInstanceProperty<aws.IMskClusterClientAuthentication[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterConfigurationInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMskClusterConfigurationInfo[]? ConfigurationInfoInput
        {
            get => GetInstanceProperty<aws.IMskClusterConfigurationInfo[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMskClusterEncryptionInfo[]? EncryptionInfoInput
        {
            get => GetInstanceProperty<aws.IMskClusterEncryptionInfo[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnhancedMonitoringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMskClusterLoggingInfo[]? LoggingInfoInput
        {
            get => GetInstanceProperty<aws.IMskClusterLoggingInfo[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openMonitoringInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoring\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IMskClusterOpenMonitoring[]? OpenMonitoringInput
        {
            get => GetInstanceProperty<aws.IMskClusterOpenMonitoring[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterBrokerNodeGroupInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterBrokerNodeGroupInfo[] BrokerNodeGroupInfo
        {
            get => GetInstanceProperty<aws.IMskClusterBrokerNodeGroupInfo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthentication\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterClientAuthentication[] ClientAuthentication
        {
            get => GetInstanceProperty<aws.IMskClusterClientAuthentication[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterConfigurationInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterConfigurationInfo[] ConfigurationInfo
        {
            get => GetInstanceProperty<aws.IMskClusterConfigurationInfo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterEncryptionInfo[] EncryptionInfo
        {
            get => GetInstanceProperty<aws.IMskClusterEncryptionInfo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnhancedMonitoring
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterLoggingInfo[] LoggingInfo
        {
            get => GetInstanceProperty<aws.IMskClusterLoggingInfo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBrokerNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "openMonitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoring\"},\"kind\":\"array\"}}")]
        public virtual aws.IMskClusterOpenMonitoring[] OpenMonitoring
        {
            get => GetInstanceProperty<aws.IMskClusterOpenMonitoring[]>()!;
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

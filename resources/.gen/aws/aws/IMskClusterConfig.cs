using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterConfig), fullyQualifiedName: "aws.MskClusterConfig")]
    public interface IMskClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>broker_node_group_info block.</summary>
        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterBrokerNodeGroupInfo\"},\"kind\":\"array\"}}")]
        aws.IMskClusterBrokerNodeGroupInfo[] BrokerNodeGroupInfo
        {
            get;
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        string KafkaVersion
        {
            get;
        }

        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfBrokerNodes
        {
            get;
        }

        /// <summary>client_authentication block.</summary>
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthentication\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterClientAuthentication[]? ClientAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration_info block.</summary>
        [JsiiProperty(name: "configurationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterConfigurationInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterConfigurationInfo[]? ConfigurationInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_info block.</summary>
        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterEncryptionInfo[]? EncryptionInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnhancedMonitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging_info block.</summary>
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterLoggingInfo[]? LoggingInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_monitoring block.</summary>
        [JsiiProperty(name: "openMonitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoring\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterOpenMonitoring[]? OpenMonitoring
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterConfig), fullyQualifiedName: "aws.MskClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>broker_node_group_info block.</summary>
            [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterBrokerNodeGroupInfo\"},\"kind\":\"array\"}}")]
            public aws.IMskClusterBrokerNodeGroupInfo[] BrokerNodeGroupInfo
            {
                get => GetInstanceProperty<aws.IMskClusterBrokerNodeGroupInfo[]>()!;
            }

            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string KafkaVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfBrokerNodes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>client_authentication block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientAuthentication", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthentication\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterClientAuthentication[]? ClientAuthentication
            {
                get => GetInstanceProperty<aws.IMskClusterClientAuthentication[]?>();
            }

            /// <summary>configuration_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterConfigurationInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterConfigurationInfo[]? ConfigurationInfo
            {
                get => GetInstanceProperty<aws.IMskClusterConfigurationInfo[]?>();
            }

            /// <summary>encryption_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterEncryptionInfo[]? EncryptionInfo
            {
                get => GetInstanceProperty<aws.IMskClusterEncryptionInfo[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnhancedMonitoring
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logging_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterLoggingInfo[]? LoggingInfo
            {
                get => GetInstanceProperty<aws.IMskClusterLoggingInfo[]?>();
            }

            /// <summary>open_monitoring block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "openMonitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoring\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterOpenMonitoring[]? OpenMonitoring
            {
                get => GetInstanceProperty<aws.IMskClusterOpenMonitoring[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}

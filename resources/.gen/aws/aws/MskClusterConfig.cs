using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterConfig")]
    public class MskClusterConfig : aws.IMskClusterConfig
    {
        /// <summary>broker_node_group_info block.</summary>
        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterBrokerNodeGroupInfo\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IMskClusterBrokerNodeGroupInfo[] BrokerNodeGroupInfo
        {
            get;
            set;
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterName
        {
            get;
            set;
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KafkaVersion
        {
            get;
            set;
        }

        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double NumberOfBrokerNodes
        {
            get;
            set;
        }

        /// <summary>client_authentication block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterClientAuthentication\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterClientAuthentication[]? ClientAuthentication
        {
            get;
            set;
        }

        /// <summary>configuration_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterConfigurationInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterConfigurationInfo[]? ConfigurationInfo
        {
            get;
            set;
        }

        /// <summary>encryption_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterEncryptionInfo[]? EncryptionInfo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedMonitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EnhancedMonitoring
        {
            get;
            set;
        }

        /// <summary>logging_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterLoggingInfo[]? LoggingInfo
        {
            get;
            set;
        }

        /// <summary>open_monitoring block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openMonitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoring\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterOpenMonitoring[]? OpenMonitoring
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MqBrokerConfig")]
    public class MqBrokerConfig : aws.IMqBrokerConfig
    {
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BrokerName
        {
            get;
            set;
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EngineType
        {
            get;
            set;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EngineVersion
        {
            get;
            set;
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HostInstanceType
        {
            get;
            set;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SecurityGroups
        {
            get;
            set;
        }

        /// <summary>user block.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerUser\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IMqBrokerUser[] User
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ApplyImmediately
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMqBrokerConfiguration[]? Configuration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeploymentMode
        {
            get;
            set;
        }

        /// <summary>encryption_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerEncryptionOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMqBrokerEncryptionOptions[]? EncryptionOptions
        {
            get;
            set;
        }

        /// <summary>logs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerLogs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMqBrokerLogs[]? Logs
        {
            get;
            set;
        }

        /// <summary>maintenance_window_start_time block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerMaintenanceWindowStartTime\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMqBrokerMaintenanceWindowStartTime[]? MaintenanceWindowStartTime
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PubliclyAccessible
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubnetIds
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

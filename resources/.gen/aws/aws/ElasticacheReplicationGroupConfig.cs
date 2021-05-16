using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticacheReplicationGroupConfig")]
    public class ElasticacheReplicationGroupConfig : aws.IElasticacheReplicationGroupConfig
    {
        [JsiiProperty(name: "replicationGroupDescription", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicationGroupDescription
        {
            get;
            set;
        }

        [JsiiProperty(name: "replicationGroupId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicationGroupId
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
        [JsiiProperty(name: "atRestEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AtRestEncryptionEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuthToken
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticFailoverEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AutomaticFailoverEnabled
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

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        /// <summary>cluster_mode block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterMode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticacheReplicationGroupClusterMode\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticacheReplicationGroupClusterMode[]? ClusterMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Engine
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaintenanceWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NodeType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotificationTopicArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberCacheClusters", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? NumberCacheClusters
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ParameterGroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroupNames
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SnapshotArns
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SnapshotName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotRetentionLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SnapshotRetentionLimit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SnapshotWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SubnetGroupName
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

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ElasticacheReplicationGroupTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IElasticacheReplicationGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? TransitEncryptionEnabled
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

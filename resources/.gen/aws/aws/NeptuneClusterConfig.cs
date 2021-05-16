using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.NeptuneClusterConfig")]
    public class NeptuneClusterConfig : aws.INeptuneClusterConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ApplyImmediately
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

        [JsiiOptional]
        [JsiiProperty(name: "backupRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BackupRetentionPeriod
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClusterIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdentifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClusterIdentifierPrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeletionProtection
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableCloudwatchLogsExports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? EnableCloudwatchLogsExports
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
        [JsiiProperty(name: "finalSnapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FinalSnapshotIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamDatabaseAuthenticationEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IamDatabaseAuthenticationEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? IamRoles
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "neptuneClusterParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NeptuneClusterParameterGroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "neptuneSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NeptuneSubnetGroupName
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
        [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreferredBackupWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreferredMaintenanceWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationSourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplicationSourceIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipFinalSnapshot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipFinalSnapshot
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SnapshotIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? StorageEncrypted
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.NeptuneClusterTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.INeptuneClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcSecurityGroupIds
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

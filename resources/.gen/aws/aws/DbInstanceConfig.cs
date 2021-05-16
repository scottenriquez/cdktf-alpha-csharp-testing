using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DbInstanceConfig")]
    public class DbInstanceConfig : aws.IDbInstanceConfig
    {
        [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceClass
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocatedStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AllocatedStorage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowMajorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowMajorVersionUpgrade
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

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AvailabilityZone
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
        [JsiiProperty(name: "backupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BackupWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "caCertIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CaCertIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "characterSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CharacterSetName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToSnapshot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CopyTagsToSnapshot
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DbSubnetGroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAutomatedBackups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeleteAutomatedBackups
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
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Domain
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainIamRoleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DomainIamRoleName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledCloudwatchLogsExports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? EnabledCloudwatchLogsExports
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
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Identifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IdentifierPrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Iops
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
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LicenseModel
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
        [JsiiProperty(name: "maxAllocatedStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxAllocatedStorage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MonitoringInterval
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MonitoringRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiAz", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? MultiAz
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OptionGroupName
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
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Password
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceInsightsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PerformanceInsightsEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceInsightsKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PerformanceInsightsKmsKeyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceInsightsRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PerformanceInsightsRetentionPeriod
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
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PubliclyAccessible
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicateSourceDb", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplicateSourceDb
        {
            get;
            set;
        }

        /// <summary>s3_import block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Import", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DbInstanceS3Import\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDbInstanceS3Import[]? S3Import
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
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StorageType
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DbInstanceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IDbInstanceTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Timezone
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Username
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

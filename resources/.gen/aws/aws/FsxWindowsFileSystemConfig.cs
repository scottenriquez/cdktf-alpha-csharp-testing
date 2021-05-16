using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.FsxWindowsFileSystemConfig")]
    public class FsxWindowsFileSystemConfig : aws.IFsxWindowsFileSystemConfig
    {
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double StorageCapacity
        {
            get;
            set;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SubnetIds
        {
            get;
            set;
        }

        [JsiiProperty(name: "throughputCapacity", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ThroughputCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ActiveDirectoryId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticBackupRetentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AutomaticBackupRetentionDays
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToBackups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CopyTagsToBackups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyAutomaticBackupStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DailyAutomaticBackupStartTime
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
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>self_managed_active_directory block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selfManagedActiveDirectory", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.FsxWindowsFileSystemSelfManagedActiveDirectory\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IFsxWindowsFileSystemSelfManagedActiveDirectory[]? SelfManagedActiveDirectory
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipFinalBackup", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipFinalBackup
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.FsxWindowsFileSystemTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IFsxWindowsFileSystemTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyMaintenanceStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WeeklyMaintenanceStartTime
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

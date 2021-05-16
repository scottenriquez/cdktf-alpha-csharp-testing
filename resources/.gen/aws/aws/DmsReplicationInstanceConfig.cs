using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DmsReplicationInstanceConfig")]
    public class DmsReplicationInstanceConfig : aws.IDmsReplicationInstanceConfig
    {
        [JsiiProperty(name: "replicationInstanceClass", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicationInstanceClass
        {
            get;
            set;
        }

        [JsiiProperty(name: "replicationInstanceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReplicationInstanceId
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
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EngineVersion
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
        [JsiiProperty(name: "multiAz", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? MultiAz
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
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PubliclyAccessible
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationSubnetGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplicationSubnetGroupId
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DmsReplicationInstanceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IDmsReplicationInstanceTimeouts? Timeouts
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EksNodeGroupConfig")]
    public class EksNodeGroupConfig : aws.IEksNodeGroupConfig
    {
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterName
        {
            get;
            set;
        }

        [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NodeGroupName
        {
            get;
            set;
        }

        [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NodeRoleArn
        {
            get;
            set;
        }

        /// <summary>scaling_config block.</summary>
        [JsiiProperty(name: "scalingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksNodeGroupScalingConfig\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IEksNodeGroupScalingConfig[] ScalingConfig
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

        [JsiiOptional]
        [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AmiType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DiskSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ForceUpdateVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? InstanceTypes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReleaseVersion
        {
            get;
            set;
        }

        /// <summary>remote_access block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteAccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksNodeGroupRemoteAccess\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEksNodeGroupRemoteAccess[]? RemoteAccess
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksNodeGroupTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IEksNodeGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.OpsworksInstanceConfig")]
    public class OpsworksInstanceConfig : aws.IOpsworksInstanceConfig
    {
        [JsiiProperty(name: "layerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] LayerIds
        {
            get;
            set;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StackId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AgentVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AmiId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Architecture
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AutoScalingType
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
        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CreatedAt
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteEbs", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeleteEbs
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteEip", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DeleteEip
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksInstanceEbsBlockDevice[]? EbsBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EbsOptimized
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EcsClusterArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ElasticIp
        {
            get;
            set;
        }

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksInstanceEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Hostname
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InfrastructureClass
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? InstallUpdatesOnBoot
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceProfileArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastServiceErrorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LastServiceErrorId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Os
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Platform
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrivateDns
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrivateIp
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PublicDns
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PublicIp
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "registeredBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RegisteredBy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedAgentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReportedAgentVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReportedOsFamily
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReportedOsName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReportedOsVersion
        {
            get;
            set;
        }

        /// <summary>root_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksInstanceRootBlockDevice[]? RootBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RootDeviceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceVolumeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RootDeviceVolumeId
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
        [JsiiProperty(name: "sshHostDsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SshHostDsaKeyFingerprint
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshHostRsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SshHostRsaKeyFingerprint
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SshKeyName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? State
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Status
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Tenancy
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.OpsworksInstanceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IOpsworksInstanceTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VirtualizationType
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

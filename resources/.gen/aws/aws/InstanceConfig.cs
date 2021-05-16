using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.InstanceConfig")]
    public class InstanceConfig : aws.IInstanceConfig
    {
        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Ami
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AssociatePublicIpAddress
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
        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CpuCoreCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CpuThreadsPerCore
        {
            get;
            set;
        }

        /// <summary>credit_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.InstanceCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IInstanceCreditSpecification[]? CreditSpecification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DisableApiTermination
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.InstanceEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IInstanceEbsBlockDevice[]? EbsBlockDevice
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

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.InstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IInstanceEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? FetchPasswordData
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hibernation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Hibernation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IamInstanceProfile
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInitiatedShutdownBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Ipv6AddressCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Ipv6Addresses
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>metadata_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.InstanceMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IInstanceMetadataOptions[]? MetadataOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Monitoring
        {
            get;
            set;
        }

        /// <summary>network_interface block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterface", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.InstanceNetworkInterface\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IInstanceNetworkInterface[]? NetworkInterface
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlacementGroup
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

        /// <summary>root_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.InstanceRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IInstanceRootBlockDevice[]? RootBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SourceDestCheck
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
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.InstanceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IInstanceTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserData
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserDataBase64
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? VolumeTags
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestConfig), fullyQualifiedName: "aws.SpotInstanceRequestConfig")]
    public interface ISpotInstanceRequestConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
        string Ami
        {
            get;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AssociatePublicIpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockDurationMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuCoreCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuThreadsPerCore
        {
            get
            {
                return null;
            }
        }

        /// <summary>credit_specification block.</summary>
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestCreditSpecification[]? CreditSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DisableApiTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_block_device block.</summary>
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestEbsBlockDevice[]? EbsBlockDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? FetchPasswordData
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hibernation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Hibernation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamInstanceProfile
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInitiatedShutdownBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInterruptionBehaviour
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ipv6AddressCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ipv6Addresses
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "launchGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata_options block.</summary>
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestMetadataOptions[]? MetadataOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Monitoring
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface block.</summary>
        [JsiiProperty(name: "networkInterface", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestNetworkInterface[]? NetworkInterface
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_block_device block.</summary>
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestRootBlockDevice[]? RootBlockDevice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SourceDestCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotPrice
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tenancy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.SpotInstanceRequestTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotInstanceRequestTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserDataBase64
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidFrom
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidUntil
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "volumeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? VolumeTags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? WaitForFulfillment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestConfig), fullyQualifiedName: "aws.SpotInstanceRequestConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISpotInstanceRequestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
            public string Ami
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AssociatePublicIpAddress
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockDurationMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuCoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuThreadsPerCore
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>credit_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotInstanceRequestCreditSpecification[]? CreditSpecification
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestCreditSpecification[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DisableApiTermination
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>ebs_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotInstanceRequestEbsBlockDevice[]? EbsBlockDevice
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestEbsBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EbsOptimized
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotInstanceRequestEphemeralBlockDevice[]? EphemeralBlockDevice
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestEphemeralBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? FetchPasswordData
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hibernation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Hibernation
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamInstanceProfile
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInitiatedShutdownBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInterruptionBehaviour
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ipv6AddressCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ipv6Addresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "launchGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metadata_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotInstanceRequestMetadataOptions[]? MetadataOptions
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestMetadataOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Monitoring
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>network_interface block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterface", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotInstanceRequestNetworkInterface[]? NetworkInterface
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestNetworkInterface[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>root_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotInstanceRequestRootBlockDevice[]? RootBlockDevice
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestRootBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SourceDestCheck
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotPrice
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenancy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.SpotInstanceRequestTimeouts\"}", isOptional: true)]
            public aws.ISpotInstanceRequestTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.ISpotInstanceRequestTimeouts?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserDataBase64
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidFrom
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidUntil
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "volumeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? VolumeTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? WaitForFulfillment
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}

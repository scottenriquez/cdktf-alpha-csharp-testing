using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchSpecification), fullyQualifiedName: "aws.SpotFleetRequestLaunchSpecification")]
    public interface ISpotFleetRequestLaunchSpecification
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

        /// <summary>ebs_block_device block.</summary>
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecificationEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotFleetRequestLaunchSpecificationEbsBlockDevice[]? EbsBlockDevice
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
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice[]? EphemeralBlockDevice
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

        [JsiiProperty(name: "iamInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamInstanceProfileArn
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

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Monitoring
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

        [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementTenancy
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_block_device block.</summary>
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecificationRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISpotFleetRequestLaunchSpecificationRootBlockDevice[]? RootBlockDevice
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

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
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

        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeightedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchSpecification), fullyQualifiedName: "aws.SpotFleetRequestLaunchSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.ISpotFleetRequestLaunchSpecification
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

            /// <summary>ebs_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecificationEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotFleetRequestLaunchSpecificationEbsBlockDevice[]? EbsBlockDevice
            {
                get => GetInstanceProperty<aws.ISpotFleetRequestLaunchSpecificationEbsBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EbsOptimized
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>ephemeral_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecificationEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice[]? EphemeralBlockDevice
            {
                get => GetInstanceProperty<aws.ISpotFleetRequestLaunchSpecificationEphemeralBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamInstanceProfile
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamInstanceProfileArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Monitoring
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementTenancy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>root_block_device block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecificationRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISpotFleetRequestLaunchSpecificationRootBlockDevice[]? RootBlockDevice
            {
                get => GetInstanceProperty<aws.ISpotFleetRequestLaunchSpecificationRootBlockDevice[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotPrice
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
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeightedCapacity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

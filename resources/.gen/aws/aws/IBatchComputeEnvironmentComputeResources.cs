using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentComputeResources), fullyQualifiedName: "aws.BatchComputeEnvironmentComputeResources")]
    public interface IBatchComputeEnvironmentComputeResources
    {
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceRole
        {
            get;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] InstanceType
        {
            get;
        }

        [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}")]
        double MaxVcpus
        {
            get;
        }

        [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}")]
        double MinVcpus
        {
            get;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BidPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredVcpus
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ec2KeyPair
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_template block.</summary>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBatchComputeEnvironmentComputeResourcesLaunchTemplate[]? LaunchTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SpotIamFleetRole
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

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentComputeResources), fullyQualifiedName: "aws.BatchComputeEnvironmentComputeResources")]
        internal sealed class _Proxy : DeputyBase, aws.IBatchComputeEnvironmentComputeResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] InstanceType
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxVcpus
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}")]
            public double MinVcpus
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BidPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredVcpus
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ec2KeyPair
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>launch_template block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBatchComputeEnvironmentComputeResourcesLaunchTemplate[]? LaunchTemplate
            {
                get => GetInstanceProperty<aws.IBatchComputeEnvironmentComputeResourcesLaunchTemplate[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SpotIamFleetRole
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}

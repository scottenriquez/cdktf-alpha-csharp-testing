using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterInstanceGroup), fullyQualifiedName: "aws.EmrClusterInstanceGroup")]
    public interface IEmrClusterInstanceGroup
    {
        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceRole
        {
            get;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiProperty(name: "autoscalingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoscalingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BidPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_config block.</summary>
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterInstanceGroupEbsConfig[]? EbsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterInstanceGroup), fullyQualifiedName: "aws.EmrClusterInstanceGroup")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterInstanceGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoscalingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoscalingPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BidPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterInstanceGroupEbsConfig[]? EbsConfig
            {
                get => GetInstanceProperty<aws.IEmrClusterInstanceGroupEbsConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

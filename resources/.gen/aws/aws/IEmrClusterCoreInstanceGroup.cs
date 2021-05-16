using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceGroup), fullyQualifiedName: "aws.EmrClusterCoreInstanceGroup")]
    public interface IEmrClusterCoreInstanceGroup
    {
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
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterCoreInstanceGroupEbsConfig[]? EbsConfig
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

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceGroup), fullyQualifiedName: "aws.EmrClusterCoreInstanceGroup")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterCoreInstanceGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterCoreInstanceGroupEbsConfig[]? EbsConfig
            {
                get => GetInstanceProperty<aws.IEmrClusterCoreInstanceGroupEbsConfig[]?>();
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

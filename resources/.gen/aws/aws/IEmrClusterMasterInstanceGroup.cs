using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterMasterInstanceGroup), fullyQualifiedName: "aws.EmrClusterMasterInstanceGroup")]
    public interface IEmrClusterMasterInstanceGroup
    {
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
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
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterMasterInstanceGroupEbsConfig[]? EbsConfig
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

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterMasterInstanceGroup), fullyQualifiedName: "aws.EmrClusterMasterInstanceGroup")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterMasterInstanceGroup
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
            [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BidPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterMasterInstanceGroupEbsConfig[]? EbsConfig
            {
                get => GetInstanceProperty<aws.IEmrClusterMasterInstanceGroupEbsConfig[]?>();
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

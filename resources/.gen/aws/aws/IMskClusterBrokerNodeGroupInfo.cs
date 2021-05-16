using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfo), fullyQualifiedName: "aws.MskClusterBrokerNodeGroupInfo")]
    public interface IMskClusterBrokerNodeGroupInfo
    {
        [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ClientSubnets
        {
            get;
        }

        [JsiiProperty(name: "ebsVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
        double EbsVolumeSize
        {
            get;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroups
        {
            get;
        }

        [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzDistribution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfo), fullyQualifiedName: "aws.MskClusterBrokerNodeGroupInfo")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterBrokerNodeGroupInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ClientSubnets
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "ebsVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
            public double EbsVolumeSize
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroups
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzDistribution
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

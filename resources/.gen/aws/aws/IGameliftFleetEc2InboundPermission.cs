using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetEc2InboundPermission), fullyQualifiedName: "aws.GameliftFleetEc2InboundPermission")]
    public interface IGameliftFleetEc2InboundPermission
    {
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        double FromPort
        {
            get;
        }

        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
        string IpRange
        {
            get;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        double ToPort
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetEc2InboundPermission), fullyQualifiedName: "aws.GameliftFleetEc2InboundPermission")]
        internal sealed class _Proxy : DeputyBase, aws.IGameliftFleetEc2InboundPermission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
            public double FromPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
            public string IpRange
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ToPort
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

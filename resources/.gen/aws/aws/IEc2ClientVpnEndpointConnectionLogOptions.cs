using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2ClientVpnEndpointConnectionLogOptions), fullyQualifiedName: "aws.Ec2ClientVpnEndpointConnectionLogOptions")]
    public interface IEc2ClientVpnEndpointConnectionLogOptions
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchLogGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchLogStream
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2ClientVpnEndpointConnectionLogOptions), fullyQualifiedName: "aws.Ec2ClientVpnEndpointConnectionLogOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2ClientVpnEndpointConnectionLogOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchLogGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchLogStream
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

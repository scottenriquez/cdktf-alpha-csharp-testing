using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMqBrokerConfiguration), fullyQualifiedName: "aws.MqBrokerConfiguration")]
    public interface IMqBrokerConfiguration
    {
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Revision
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerConfiguration), fullyQualifiedName: "aws.MqBrokerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IMqBrokerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Revision
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

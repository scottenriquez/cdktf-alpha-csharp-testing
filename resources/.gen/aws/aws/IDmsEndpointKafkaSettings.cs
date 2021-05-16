using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointKafkaSettings), fullyQualifiedName: "aws.DmsEndpointKafkaSettings")]
    public interface IDmsEndpointKafkaSettings
    {
        [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
        string Broker
        {
            get;
        }

        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Topic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointKafkaSettings), fullyQualifiedName: "aws.DmsEndpointKafkaSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsEndpointKafkaSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
            public string Broker
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Topic
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

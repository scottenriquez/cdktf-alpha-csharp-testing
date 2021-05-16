using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorEndpointGroupEndpointConfiguration), fullyQualifiedName: "aws.GlobalacceleratorEndpointGroupEndpointConfiguration")]
    public interface IGlobalacceleratorEndpointGroupEndpointConfiguration
    {
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorEndpointGroupEndpointConfiguration), fullyQualifiedName: "aws.GlobalacceleratorEndpointGroupEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IGlobalacceleratorEndpointGroupEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

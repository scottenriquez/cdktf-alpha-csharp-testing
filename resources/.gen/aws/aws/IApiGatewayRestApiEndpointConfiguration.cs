using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayRestApiEndpointConfiguration), fullyQualifiedName: "aws.ApiGatewayRestApiEndpointConfiguration")]
    public interface IApiGatewayRestApiEndpointConfiguration
    {
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Types
        {
            get;
        }

        [JsiiProperty(name: "vpcEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcEndpointIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayRestApiEndpointConfiguration), fullyQualifiedName: "aws.ApiGatewayRestApiEndpointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayRestApiEndpointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Types
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcEndpointIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

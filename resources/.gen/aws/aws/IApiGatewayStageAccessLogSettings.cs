using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayStageAccessLogSettings), fullyQualifiedName: "aws.ApiGatewayStageAccessLogSettings")]
    public interface IApiGatewayStageAccessLogSettings
    {
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationArn
        {
            get;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayStageAccessLogSettings), fullyQualifiedName: "aws.ApiGatewayStageAccessLogSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayStageAccessLogSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

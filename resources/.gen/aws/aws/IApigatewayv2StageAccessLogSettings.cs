using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2StageAccessLogSettings), fullyQualifiedName: "aws.Apigatewayv2StageAccessLogSettings")]
    public interface IApigatewayv2StageAccessLogSettings
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

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2StageAccessLogSettings), fullyQualifiedName: "aws.Apigatewayv2StageAccessLogSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2StageAccessLogSettings
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayApiKeyStageKey), fullyQualifiedName: "aws.ApiGatewayApiKeyStageKey")]
    public interface IApiGatewayApiKeyStageKey
    {
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        string StageName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayApiKeyStageKey), fullyQualifiedName: "aws.ApiGatewayApiKeyStageKey")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayApiKeyStageKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
            public string StageName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

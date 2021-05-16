using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanApiStages), fullyQualifiedName: "aws.ApiGatewayUsagePlanApiStages")]
    public interface IApiGatewayUsagePlanApiStages
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
        string Stage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanApiStages), fullyQualifiedName: "aws.ApiGatewayUsagePlanApiStages")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayUsagePlanApiStages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stage", typeJson: "{\"primitive\":\"string\"}")]
            public string Stage
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

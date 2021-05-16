using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanQuotaSettings), fullyQualifiedName: "aws.ApiGatewayUsagePlanQuotaSettings")]
    public interface IApiGatewayUsagePlanQuotaSettings
    {
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        string Period
        {
            get;
        }

        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Offset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanQuotaSettings), fullyQualifiedName: "aws.ApiGatewayUsagePlanQuotaSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayUsagePlanQuotaSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
            public string Period
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Offset
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

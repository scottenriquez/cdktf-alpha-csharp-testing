using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanThrottleSettings), fullyQualifiedName: "aws.ApiGatewayUsagePlanThrottleSettings")]
    public interface IApiGatewayUsagePlanThrottleSettings
    {
        [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BurstLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RateLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanThrottleSettings), fullyQualifiedName: "aws.ApiGatewayUsagePlanThrottleSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayUsagePlanThrottleSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BurstLimit
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RateLimit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

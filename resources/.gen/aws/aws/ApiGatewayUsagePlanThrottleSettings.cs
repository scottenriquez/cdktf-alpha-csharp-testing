using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ApiGatewayUsagePlanThrottleSettings")]
    public class ApiGatewayUsagePlanThrottleSettings : aws.IApiGatewayUsagePlanThrottleSettings
    {
        [JsiiOptional]
        [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BurstLimit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RateLimit
        {
            get;
            set;
        }
    }
}

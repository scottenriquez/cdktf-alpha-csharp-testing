using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayUsagePlanQuotaSettings")]
    public class ApiGatewayUsagePlanQuotaSettings : aws.IApiGatewayUsagePlanQuotaSettings
    {
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Limit
        {
            get;
            set;
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Period
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Offset
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Apigatewayv2StageRouteSettings")]
    public class Apigatewayv2StageRouteSettings : aws.IApigatewayv2StageRouteSettings
    {
        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RouteKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DataTraceEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailedMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DetailedMetricsEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LoggingLevel
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "throttlingBurstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ThrottlingBurstLimit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "throttlingRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ThrottlingRateLimit
        {
            get;
            set;
        }
    }
}

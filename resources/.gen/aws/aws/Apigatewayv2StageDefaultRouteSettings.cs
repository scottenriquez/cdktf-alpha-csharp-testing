using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Apigatewayv2StageDefaultRouteSettings")]
    public class Apigatewayv2StageDefaultRouteSettings : aws.IApigatewayv2StageDefaultRouteSettings
    {
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

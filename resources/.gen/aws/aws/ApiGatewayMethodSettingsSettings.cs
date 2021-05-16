using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ApiGatewayMethodSettingsSettings")]
    public class ApiGatewayMethodSettingsSettings : aws.IApiGatewayMethodSettingsSettings
    {
        [JsiiOptional]
        [JsiiProperty(name: "cacheDataEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CacheDataEncrypted
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CacheTtlInSeconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CachingEnabled
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
        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LoggingLevel
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? MetricsEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireAuthorizationForCacheControl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequireAuthorizationForCacheControl
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

        [JsiiOptional]
        [JsiiProperty(name: "unauthorizedCacheControlHeaderStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UnauthorizedCacheControlHeaderStrategy
        {
            get;
            set;
        }
    }
}

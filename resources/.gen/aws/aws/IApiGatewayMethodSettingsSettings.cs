using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayMethodSettingsSettings), fullyQualifiedName: "aws.ApiGatewayMethodSettingsSettings")]
    public interface IApiGatewayMethodSettingsSettings
    {
        [JsiiProperty(name: "cacheDataEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? CacheDataEncrypted
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cacheTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheTtlInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cachingEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? CachingEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DataTraceEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoggingLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "metricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? MetricsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requireAuthorizationForCacheControl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RequireAuthorizationForCacheControl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "throttlingBurstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThrottlingBurstLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "throttlingRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThrottlingRateLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "unauthorizedCacheControlHeaderStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnauthorizedCacheControlHeaderStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayMethodSettingsSettings), fullyQualifiedName: "aws.ApiGatewayMethodSettingsSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayMethodSettingsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "cacheDataEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? CacheDataEncrypted
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cacheTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheTtlInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cachingEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? CachingEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DataTraceEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoggingLevel
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? MetricsEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requireAuthorizationForCacheControl", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RequireAuthorizationForCacheControl
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "throttlingBurstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThrottlingBurstLimit
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "throttlingRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThrottlingRateLimit
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "unauthorizedCacheControlHeaderStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnauthorizedCacheControlHeaderStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

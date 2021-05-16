using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2StageDefaultRouteSettings), fullyQualifiedName: "aws.Apigatewayv2StageDefaultRouteSettings")]
    public interface IApigatewayv2StageDefaultRouteSettings
    {
        [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DataTraceEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "detailedMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DetailedMetricsEnabled
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

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2StageDefaultRouteSettings), fullyQualifiedName: "aws.Apigatewayv2StageDefaultRouteSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2StageDefaultRouteSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DataTraceEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "detailedMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DetailedMetricsEnabled
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
        }
    }
}

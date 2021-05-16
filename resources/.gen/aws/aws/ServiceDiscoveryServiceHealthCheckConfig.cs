using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ServiceDiscoveryServiceHealthCheckConfig")]
    public class ServiceDiscoveryServiceHealthCheckConfig : aws.IServiceDiscoveryServiceHealthCheckConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResourcePath
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}

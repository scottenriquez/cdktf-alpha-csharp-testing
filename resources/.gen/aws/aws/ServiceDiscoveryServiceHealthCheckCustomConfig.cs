using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ServiceDiscoveryServiceHealthCheckCustomConfig")]
    public class ServiceDiscoveryServiceHealthCheckCustomConfig : aws.IServiceDiscoveryServiceHealthCheckCustomConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }
    }
}

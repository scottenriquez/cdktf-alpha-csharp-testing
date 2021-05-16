using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlobalacceleratorEndpointGroupConfig")]
    public class GlobalacceleratorEndpointGroupConfig : aws.IGlobalacceleratorEndpointGroupConfig
    {
        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ListenerArn
        {
            get;
            set;
        }

        /// <summary>endpoint_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlobalacceleratorEndpointGroupEndpointConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlobalacceleratorEndpointGroupEndpointConfiguration[]? EndpointConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointGroupRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EndpointGroupRegion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HealthCheckIntervalSeconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HealthCheckPath
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HealthCheckPort
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HealthCheckProtocol
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ThresholdCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficDialPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TrafficDialPercentage
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}

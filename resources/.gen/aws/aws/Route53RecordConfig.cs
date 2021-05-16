using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Route53RecordConfig")]
    public class Route53RecordConfig : aws.IRoute53RecordConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ZoneId
        {
            get;
            set;
        }

        /// <summary>alias block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordAlias\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IRoute53RecordAlias[]? Alias
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllowOverwrite
        {
            get;
            set;
        }

        /// <summary>failover_routing_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IRoute53RecordFailoverRoutingPolicy[]? FailoverRoutingPolicy
        {
            get;
            set;
        }

        /// <summary>geolocation_routing_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IRoute53RecordGeolocationRoutingPolicy[]? GeolocationRoutingPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HealthCheckId
        {
            get;
            set;
        }

        /// <summary>latency_routing_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IRoute53RecordLatencyRoutingPolicy[]? LatencyRoutingPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? MultivalueAnswerRoutingPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Records
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SetIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Ttl
        {
            get;
            set;
        }

        /// <summary>weighted_routing_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IRoute53RecordWeightedRoutingPolicy[]? WeightedRoutingPolicy
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

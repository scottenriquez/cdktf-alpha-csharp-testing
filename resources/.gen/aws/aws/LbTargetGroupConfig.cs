using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LbTargetGroupConfig")]
    public class LbTargetGroupConfig : aws.ILbTargetGroupConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "deregistrationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DeregistrationDelay
        {
            get;
            set;
        }

        /// <summary>health_check block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbTargetGroupHealthCheck\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbTargetGroupHealthCheck[]? HealthCheck
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaMultiValueHeadersEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? LambdaMultiValueHeadersEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingAlgorithmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LoadBalancingAlgorithmType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Protocol
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyProtocolV2", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ProxyProtocolV2
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SlowStart
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LbTargetGroupStickiness\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILbTargetGroupStickiness[]? Stickiness
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VpcId
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

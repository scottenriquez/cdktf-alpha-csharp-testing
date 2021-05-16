using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordConfig), fullyQualifiedName: "aws.Route53RecordConfig")]
    public interface IRoute53RecordConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>alias block.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordAlias\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IRoute53RecordAlias[]? Alias
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowOverwrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>failover_routing_policy block.</summary>
        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IRoute53RecordFailoverRoutingPolicy[]? FailoverRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>geolocation_routing_policy block.</summary>
        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IRoute53RecordGeolocationRoutingPolicy[]? GeolocationRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckId
        {
            get
            {
                return null;
            }
        }

        /// <summary>latency_routing_policy block.</summary>
        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IRoute53RecordLatencyRoutingPolicy[]? LatencyRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? MultivalueAnswerRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Records
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SetIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        /// <summary>weighted_routing_policy block.</summary>
        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IRoute53RecordWeightedRoutingPolicy[]? WeightedRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordConfig), fullyQualifiedName: "aws.Route53RecordConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IRoute53RecordConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alias block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordAlias\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IRoute53RecordAlias[]? Alias
            {
                get => GetInstanceProperty<aws.IRoute53RecordAlias[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowOverwrite", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowOverwrite
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>failover_routing_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IRoute53RecordFailoverRoutingPolicy[]? FailoverRoutingPolicy
            {
                get => GetInstanceProperty<aws.IRoute53RecordFailoverRoutingPolicy[]?>();
            }

            /// <summary>geolocation_routing_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IRoute53RecordGeolocationRoutingPolicy[]? GeolocationRoutingPolicy
            {
                get => GetInstanceProperty<aws.IRoute53RecordGeolocationRoutingPolicy[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>latency_routing_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IRoute53RecordLatencyRoutingPolicy[]? LatencyRoutingPolicy
            {
                get => GetInstanceProperty<aws.IRoute53RecordLatencyRoutingPolicy[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? MultivalueAnswerRoutingPolicy
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Records
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SetIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>weighted_routing_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IRoute53RecordWeightedRoutingPolicy[]? WeightedRoutingPolicy
            {
                get => GetInstanceProperty<aws.IRoute53RecordWeightedRoutingPolicy[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}

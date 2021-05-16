using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorEndpointGroupConfig), fullyQualifiedName: "aws.GlobalacceleratorEndpointGroupConfig")]
    public interface IGlobalacceleratorEndpointGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
        string ListenerArn
        {
            get;
        }

        /// <summary>endpoint_configuration block.</summary>
        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlobalacceleratorEndpointGroupEndpointConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlobalacceleratorEndpointGroupEndpointConfiguration[]? EndpointConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "endpointGroupRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointGroupRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "healthCheckIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckIntervalSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckPath
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckPort
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "healthCheckProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "thresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "trafficDialPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrafficDialPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorEndpointGroupConfig), fullyQualifiedName: "aws.GlobalacceleratorEndpointGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IGlobalacceleratorEndpointGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ListenerArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>endpoint_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlobalacceleratorEndpointGroupEndpointConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlobalacceleratorEndpointGroupEndpointConfiguration[]? EndpointConfiguration
            {
                get => GetInstanceProperty<aws.IGlobalacceleratorEndpointGroupEndpointConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "endpointGroupRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointGroupRegion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "healthCheckIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckIntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckPath
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckPort
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "healthCheckProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "thresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "trafficDialPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrafficDialPercentage
            {
                get => GetInstanceProperty<double?>();
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

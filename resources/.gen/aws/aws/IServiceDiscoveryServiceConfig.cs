using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceConfig), fullyQualifiedName: "aws.ServiceDiscoveryServiceConfig")]
    public interface IServiceDiscoveryServiceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dns_config block.</summary>
        [JsiiProperty(name: "dnsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IServiceDiscoveryServiceDnsConfig[]? DnsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_config block.</summary>
        [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IServiceDiscoveryServiceHealthCheckConfig[]? HealthCheckConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check_custom_config block.</summary>
        [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckCustomConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IServiceDiscoveryServiceHealthCheckCustomConfig[]? HealthCheckCustomConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamespaceId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceConfig), fullyQualifiedName: "aws.ServiceDiscoveryServiceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IServiceDiscoveryServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dns_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceDnsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IServiceDiscoveryServiceDnsConfig[]? DnsConfig
            {
                get => GetInstanceProperty<aws.IServiceDiscoveryServiceDnsConfig[]?>();
            }

            /// <summary>health_check_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IServiceDiscoveryServiceHealthCheckConfig[]? HealthCheckConfig
            {
                get => GetInstanceProperty<aws.IServiceDiscoveryServiceHealthCheckConfig[]?>();
            }

            /// <summary>health_check_custom_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ServiceDiscoveryServiceHealthCheckCustomConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IServiceDiscoveryServiceHealthCheckCustomConfig[]? HealthCheckCustomConfig
            {
                get => GetInstanceProperty<aws.IServiceDiscoveryServiceHealthCheckCustomConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamespaceId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigConfig), fullyQualifiedName: "aws.CodedeployDeploymentConfigConfig")]
    public interface ICodedeployDeploymentConfigConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentConfigName
        {
            get;
        }

        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputePlatform
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum_healthy_hosts block.</summary>
        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigMinimumHealthyHosts\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentConfigMinimumHealthyHosts[]? MinimumHealthyHosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>traffic_routing_config block.</summary>
        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentConfigTrafficRoutingConfig[]? TrafficRoutingConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigConfig), fullyQualifiedName: "aws.CodedeployDeploymentConfigConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentConfigName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputePlatform
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>minimum_healthy_hosts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigMinimumHealthyHosts\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentConfigMinimumHealthyHosts[]? MinimumHealthyHosts
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentConfigMinimumHealthyHosts[]?>();
            }

            /// <summary>traffic_routing_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentConfigTrafficRoutingConfig[]? TrafficRoutingConfig
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentConfigTrafficRoutingConfig[]?>();
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

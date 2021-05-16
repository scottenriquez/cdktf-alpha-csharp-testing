using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsClusterConfig), fullyQualifiedName: "aws.EcsClusterConfig")]
    public interface IEcsClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "capacityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CapacityProviders
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_capacity_provider_strategy block.</summary>
        [JsiiProperty(name: "defaultCapacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsClusterDefaultCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsClusterDefaultCapacityProviderStrategy[]? DefaultCapacityProviderStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>setting block.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsClusterSetting\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsClusterSetting[]? Setting
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

        [JsiiTypeProxy(nativeType: typeof(IEcsClusterConfig), fullyQualifiedName: "aws.EcsClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsClusterConfig
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
            [JsiiProperty(name: "capacityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CapacityProviders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>default_capacity_provider_strategy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultCapacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsClusterDefaultCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsClusterDefaultCapacityProviderStrategy[]? DefaultCapacityProviderStrategy
            {
                get => GetInstanceProperty<aws.IEcsClusterDefaultCapacityProviderStrategy[]?>();
            }

            /// <summary>setting block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "setting", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsClusterSetting\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsClusterSetting[]? Setting
            {
                get => GetInstanceProperty<aws.IEcsClusterSetting[]?>();
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

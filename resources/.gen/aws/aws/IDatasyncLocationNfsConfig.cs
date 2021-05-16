using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationNfsConfig), fullyQualifiedName: "aws.DatasyncLocationNfsConfig")]
    public interface IDatasyncLocationNfsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>on_prem_config block.</summary>
        [JsiiProperty(name: "onPremConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationNfsOnPremConfig\"},\"kind\":\"array\"}}")]
        aws.IDatasyncLocationNfsOnPremConfig[] OnPremConfig
        {
            get;
        }

        [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
        string ServerHostname
        {
            get;
        }

        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        string Subdirectory
        {
            get;
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

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationNfsConfig), fullyQualifiedName: "aws.DatasyncLocationNfsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationNfsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_prem_config block.</summary>
            [JsiiProperty(name: "onPremConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationNfsOnPremConfig\"},\"kind\":\"array\"}}")]
            public aws.IDatasyncLocationNfsOnPremConfig[] OnPremConfig
            {
                get => GetInstanceProperty<aws.IDatasyncLocationNfsOnPremConfig[]>()!;
            }

            [JsiiProperty(name: "serverHostname", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerHostname
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
            public string Subdirectory
            {
                get => GetInstanceProperty<string>()!;
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

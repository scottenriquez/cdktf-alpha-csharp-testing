using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationConfig), fullyQualifiedName: "aws.GlueSecurityConfigurationConfig")]
    public interface IGlueSecurityConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>encryption_configuration block.</summary>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}")]
        aws.IGlueSecurityConfigurationEncryptionConfiguration[] EncryptionConfiguration
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationConfig), fullyQualifiedName: "aws.GlueSecurityConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueSecurityConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>encryption_configuration block.</summary>
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueSecurityConfigurationEncryptionConfiguration\"},\"kind\":\"array\"}}")]
            public aws.IGlueSecurityConfigurationEncryptionConfiguration[] EncryptionConfiguration
            {
                get => GetInstanceProperty<aws.IGlueSecurityConfigurationEncryptionConfiguration[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
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

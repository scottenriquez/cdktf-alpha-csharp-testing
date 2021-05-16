using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsKmsSecretsConfig), fullyQualifiedName: "aws.DataAwsKmsSecretsConfig")]
    public interface IDataAwsKmsSecretsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>secret block.</summary>
        [JsiiProperty(name: "secret", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsKmsSecretsSecret\"},\"kind\":\"array\"}}")]
        aws.IDataAwsKmsSecretsSecret[] Secret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsKmsSecretsConfig), fullyQualifiedName: "aws.DataAwsKmsSecretsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsKmsSecretsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>secret block.</summary>
            [JsiiProperty(name: "secret", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsKmsSecretsSecret\"},\"kind\":\"array\"}}")]
            public aws.IDataAwsKmsSecretsSecret[] Secret
            {
                get => GetInstanceProperty<aws.IDataAwsKmsSecretsSecret[]>()!;
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
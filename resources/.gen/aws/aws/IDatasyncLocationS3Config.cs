using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationS3Config), fullyQualifiedName: "aws.DatasyncLocationS3Config")]
    public interface IDatasyncLocationS3Config : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "s3BucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketArn
        {
            get;
        }

        /// <summary>s3_config block.</summary>
        [JsiiProperty(name: "s3Config", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationS3S3Config\"},\"kind\":\"array\"}}")]
        aws.IDatasyncLocationS3S3Config[] S3Config
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

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationS3Config), fullyQualifiedName: "aws.DatasyncLocationS3Config")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationS3Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "s3BucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_config block.</summary>
            [JsiiProperty(name: "s3Config", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationS3S3Config\"},\"kind\":\"array\"}}")]
            public aws.IDatasyncLocationS3S3Config[] S3Config
            {
                get => GetInstanceProperty<aws.IDatasyncLocationS3S3Config[]>()!;
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

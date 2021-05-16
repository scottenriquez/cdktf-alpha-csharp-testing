using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationEfsConfig), fullyQualifiedName: "aws.DatasyncLocationEfsConfig")]
    public interface IDatasyncLocationEfsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>ec2_config block.</summary>
        [JsiiProperty(name: "ec2Config", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationEfsEc2Config\"},\"kind\":\"array\"}}")]
        aws.IDatasyncLocationEfsEc2Config[] Ec2Config
        {
            get;
        }

        [JsiiProperty(name: "efsFileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        string EfsFileSystemArn
        {
            get;
        }

        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subdirectory
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

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationEfsConfig), fullyQualifiedName: "aws.DatasyncLocationEfsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationEfsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ec2_config block.</summary>
            [JsiiProperty(name: "ec2Config", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DatasyncLocationEfsEc2Config\"},\"kind\":\"array\"}}")]
            public aws.IDatasyncLocationEfsEc2Config[] Ec2Config
            {
                get => GetInstanceProperty<aws.IDatasyncLocationEfsEc2Config[]>()!;
            }

            [JsiiProperty(name: "efsFileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
            public string EfsFileSystemArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subdirectory
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

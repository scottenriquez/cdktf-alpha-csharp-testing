using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3AccessPointConfig), fullyQualifiedName: "aws.S3AccessPointConfig")]
    public interface IS3AccessPointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_access_block_configuration block.</summary>
        [JsiiProperty(name: "publicAccessBlockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointPublicAccessBlockConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3AccessPointPublicAccessBlockConfiguration[]? PublicAccessBlockConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_configuration block.</summary>
        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3AccessPointVpcConfiguration[]? VpcConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3AccessPointConfig), fullyQualifiedName: "aws.S3AccessPointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IS3AccessPointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_access_block_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicAccessBlockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointPublicAccessBlockConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3AccessPointPublicAccessBlockConfiguration[]? PublicAccessBlockConfiguration
            {
                get => GetInstanceProperty<aws.IS3AccessPointPublicAccessBlockConfiguration[]?>();
            }

            /// <summary>vpc_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3AccessPointVpcConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3AccessPointVpcConfiguration[]? VpcConfiguration
            {
                get => GetInstanceProperty<aws.IS3AccessPointVpcConfiguration[]?>();
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

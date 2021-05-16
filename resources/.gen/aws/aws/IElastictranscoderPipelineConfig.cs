using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPipelineConfig), fullyQualifiedName: "aws.ElastictranscoderPipelineConfig")]
    public interface IElastictranscoderPipelineConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
        string InputBucket
        {
            get;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsKmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>content_config block.</summary>
        [JsiiProperty(name: "contentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPipelineContentConfig[]? ContentConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>content_config_permissions block.</summary>
        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPipelineContentConfigPermissions[]? ContentConfigPermissions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>notifications block.</summary>
        [JsiiProperty(name: "notifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineNotifications\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPipelineNotifications[]? Notifications
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputBucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>thumbnail_config block.</summary>
        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPipelineThumbnailConfig[]? ThumbnailConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>thumbnail_config_permissions block.</summary>
        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElastictranscoderPipelineThumbnailConfigPermissions[]? ThumbnailConfigPermissions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPipelineConfig), fullyQualifiedName: "aws.ElastictranscoderPipelineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElastictranscoderPipelineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}")]
            public string InputBucket
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsKmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>content_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPipelineContentConfig[]? ContentConfig
            {
                get => GetInstanceProperty<aws.IElastictranscoderPipelineContentConfig[]?>();
            }

            /// <summary>content_config_permissions block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPipelineContentConfigPermissions[]? ContentConfigPermissions
            {
                get => GetInstanceProperty<aws.IElastictranscoderPipelineContentConfigPermissions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>notifications block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineNotifications\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPipelineNotifications[]? Notifications
            {
                get => GetInstanceProperty<aws.IElastictranscoderPipelineNotifications[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputBucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>thumbnail_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPipelineThumbnailConfig[]? ThumbnailConfig
            {
                get => GetInstanceProperty<aws.IElastictranscoderPipelineThumbnailConfig[]?>();
            }

            /// <summary>thumbnail_config_permissions block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElastictranscoderPipelineThumbnailConfigPermissions[]? ThumbnailConfigPermissions
            {
                get => GetInstanceProperty<aws.IElastictranscoderPipelineThumbnailConfigPermissions[]?>();
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

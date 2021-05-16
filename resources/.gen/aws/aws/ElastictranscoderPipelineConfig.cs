using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElastictranscoderPipelineConfig")]
    public class ElastictranscoderPipelineConfig : aws.IElastictranscoderPipelineConfig
    {
        [JsiiProperty(name: "inputBucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InputBucket
        {
            get;
            set;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Role
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AwsKmsKeyArn
        {
            get;
            set;
        }

        /// <summary>content_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPipelineContentConfig[]? ContentConfig
        {
            get;
            set;
        }

        /// <summary>content_config_permissions block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineContentConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPipelineContentConfigPermissions[]? ContentConfigPermissions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>notifications block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineNotifications\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPipelineNotifications[]? Notifications
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputBucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OutputBucket
        {
            get;
            set;
        }

        /// <summary>thumbnail_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPipelineThumbnailConfig[]? ThumbnailConfig
        {
            get;
            set;
        }

        /// <summary>thumbnail_config_permissions block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thumbnailConfigPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElastictranscoderPipelineThumbnailConfigPermissions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElastictranscoderPipelineThumbnailConfigPermissions[]? ThumbnailConfigPermissions
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}

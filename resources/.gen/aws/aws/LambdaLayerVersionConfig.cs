using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaLayerVersionConfig")]
    public class LambdaLayerVersionConfig : aws.ILambdaLayerVersionConfig
    {
        [JsiiProperty(name: "layerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LayerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatibleRuntimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CompatibleRuntimes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Filename
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LicenseInfo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3Key
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3ObjectVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceCodeHash
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

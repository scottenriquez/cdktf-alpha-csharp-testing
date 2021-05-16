using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CurReportDefinitionConfig")]
    public class CurReportDefinitionConfig : aws.ICurReportDefinitionConfig
    {
        [JsiiProperty(name: "additionalSchemaElements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] AdditionalSchemaElements
        {
            get;
            set;
        }

        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Compression
        {
            get;
            set;
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Format
        {
            get;
            set;
        }

        [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReportName
        {
            get;
            set;
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3Bucket
        {
            get;
            set;
        }

        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3Region
        {
            get;
            set;
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TimeUnit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AdditionalArtifacts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3Prefix
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

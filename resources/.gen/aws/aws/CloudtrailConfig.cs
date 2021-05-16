using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudtrailConfig")]
    public class CloudtrailConfig : aws.ICloudtrailConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3BucketName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchLogsGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudWatchLogsGroupArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudWatchLogsRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableLogFileValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableLogFileValidation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableLogging", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableLogging
        {
            get;
            set;
        }

        /// <summary>event_selector block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventSelector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudtrailEventSelector\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudtrailEventSelector[]? EventSelector
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeGlobalServiceEvents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeGlobalServiceEvents
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "isMultiRegionTrail", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IsMultiRegionTrail
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "isOrganizationTrail", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IsOrganizationTrail
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsTopicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SnsTopicName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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

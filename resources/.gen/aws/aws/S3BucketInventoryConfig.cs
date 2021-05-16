using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketInventoryConfig")]
    public class S3BucketInventoryConfig : aws.IS3BucketInventoryConfig
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>destination block.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestination\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketInventoryDestination[] Destination
        {
            get;
            set;
        }

        [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IncludedObjectVersions
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>schedule block.</summary>
        [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventorySchedule\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketInventorySchedule[] Schedule
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketInventoryFilter[]? Filter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? OptionalFields
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

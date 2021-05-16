using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MacieS3BucketAssociationConfig")]
    public class MacieS3BucketAssociationConfig : aws.IMacieS3BucketAssociationConfig
    {
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>classification_type block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classificationType", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MacieS3BucketAssociationClassificationType\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMacieS3BucketAssociationClassificationType[]? ClassificationType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "memberAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MemberAccountId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
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

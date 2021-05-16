using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketLifecycleRule")]
    public class S3BucketLifecycleRule : aws.IS3BucketLifecycleRule
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AbortIncompleteMultipartUploadDays
        {
            get;
            set;
        }

        /// <summary>expiration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleExpiration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketLifecycleRuleExpiration[]? Expiration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>noncurrent_version_expiration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleNoncurrentVersionExpiration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketLifecycleRuleNoncurrentVersionExpiration[]? NoncurrentVersionExpiration
        {
            get;
            set;
        }

        /// <summary>noncurrent_version_transition block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionTransition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketLifecycleRuleNoncurrentVersionTransition[]? NoncurrentVersionTransition
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

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>transition block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleTransition\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketLifecycleRuleTransition[]? Transition
        {
            get;
            set;
        }
    }
}

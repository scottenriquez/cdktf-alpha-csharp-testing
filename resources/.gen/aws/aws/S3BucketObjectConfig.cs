using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketObjectConfig")]
    public class S3BucketObjectConfig : aws.IS3BucketObjectConfig
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bucket
        {
            get;
            set;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Key
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Acl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CacheControl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Content
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentBase64
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentDisposition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentDisposition
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentEncoding
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentLanguage
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ContentType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Etag
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ForceDestroy
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
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLockLegalHoldStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ObjectLockLegalHoldStatus
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLockMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ObjectLockMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLockRetainUntilDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ObjectLockRetainUntilDate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServerSideEncryption
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Source
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StorageClass
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

        [JsiiOptional]
        [JsiiProperty(name: "websiteRedirect", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WebsiteRedirect
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

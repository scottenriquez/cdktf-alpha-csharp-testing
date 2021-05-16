using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3BucketConfig")]
    public class S3BucketConfig : aws.IS3BucketConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "accelerationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccelerationStatus
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
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }

        /// <summary>cors_rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "corsRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketCorsRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketCorsRule[]? CorsRule
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

        /// <summary>grant block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grant", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketGrant\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketGrant[]? Grant
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostedZoneId
        {
            get;
            set;
        }

        /// <summary>lifecycle_rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketLifecycleRule[]? LifecycleRule
        {
            get;
            set;
        }

        /// <summary>logging block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLogging\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketLogging[]? Logging
        {
            get;
            set;
        }

        /// <summary>object_lock_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectLockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketObjectLockConfiguration[]? ObjectLockConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Policy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>replication_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketReplicationConfiguration[]? ReplicationConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestPayer", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RequestPayer
        {
            get;
            set;
        }

        /// <summary>server_side_encryption_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketServerSideEncryptionConfiguration[]? ServerSideEncryptionConfiguration
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

        /// <summary>versioning block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versioning", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketVersioning\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketVersioning[]? Versioning
        {
            get;
            set;
        }

        /// <summary>website block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "website", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketWebsite\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketWebsite[]? Website
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WebsiteDomain
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WebsiteEndpoint
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

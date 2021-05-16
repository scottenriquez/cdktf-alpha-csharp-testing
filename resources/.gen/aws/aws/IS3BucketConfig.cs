using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketConfig), fullyQualifiedName: "aws.S3BucketConfig")]
    public interface IS3BucketConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "accelerationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccelerationStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Acl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors_rule block.</summary>
        [JsiiProperty(name: "corsRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketCorsRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketCorsRule[]? CorsRule
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ForceDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>grant block.</summary>
        [JsiiProperty(name: "grant", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketGrant\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketGrant[]? Grant
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostedZoneId
        {
            get
            {
                return null;
            }
        }

        /// <summary>lifecycle_rule block.</summary>
        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketLifecycleRule[]? LifecycleRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLogging\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketLogging[]? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>object_lock_configuration block.</summary>
        [JsiiProperty(name: "objectLockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketObjectLockConfiguration[]? ObjectLockConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>replication_configuration block.</summary>
        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketReplicationConfiguration[]? ReplicationConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "requestPayer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestPayer
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_side_encryption_configuration block.</summary>
        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketServerSideEncryptionConfiguration[]? ServerSideEncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>versioning block.</summary>
        [JsiiProperty(name: "versioning", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketVersioning\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketVersioning[]? Versioning
        {
            get
            {
                return null;
            }
        }

        /// <summary>website block.</summary>
        [JsiiProperty(name: "website", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketWebsite\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketWebsite[]? Website
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebsiteDomain
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebsiteEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketConfig), fullyQualifiedName: "aws.S3BucketConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "accelerationStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccelerationStatus
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Acl
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cors_rule block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "corsRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketCorsRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketCorsRule[]? CorsRule
            {
                get => GetInstanceProperty<aws.IS3BucketCorsRule[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "forceDestroy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ForceDestroy
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>grant block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grant", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketGrant\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketGrant[]? Grant
            {
                get => GetInstanceProperty<aws.IS3BucketGrant[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostedZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lifecycle_rule block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketLifecycleRule[]? LifecycleRule
            {
                get => GetInstanceProperty<aws.IS3BucketLifecycleRule[]?>();
            }

            /// <summary>logging block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLogging\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketLogging[]? Logging
            {
                get => GetInstanceProperty<aws.IS3BucketLogging[]?>();
            }

            /// <summary>object_lock_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectLockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketObjectLockConfiguration[]? ObjectLockConfiguration
            {
                get => GetInstanceProperty<aws.IS3BucketObjectLockConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>replication_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketReplicationConfiguration[]? ReplicationConfiguration
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "requestPayer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestPayer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>server_side_encryption_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketServerSideEncryptionConfiguration[]? ServerSideEncryptionConfiguration
            {
                get => GetInstanceProperty<aws.IS3BucketServerSideEncryptionConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>versioning block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versioning", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketVersioning\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketVersioning[]? Versioning
            {
                get => GetInstanceProperty<aws.IS3BucketVersioning[]?>();
            }

            /// <summary>website block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "website", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketWebsite\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketWebsite[]? Website
            {
                get => GetInstanceProperty<aws.IS3BucketWebsite[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebsiteDomain
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebsiteEndpoint
            {
                get => GetInstanceProperty<string?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket), fullyQualifiedName: "aws.S3Bucket", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.S3BucketConfig\"}}]")]
    public class S3Bucket : HashiCorp.Cdktf.TerraformResource
    {
        public S3Bucket(Constructs.Construct scope, string id, aws.IS3BucketConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3Bucket(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3Bucket(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccelerationStatus")]
        public virtual void ResetAccelerationStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcl")]
        public virtual void ResetAcl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketPrefix")]
        public virtual void ResetBucketPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrant")]
        public virtual void ResetGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostedZoneId")]
        public virtual void ResetHostedZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleRule")]
        public virtual void ResetLifecycleRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectLockConfiguration")]
        public virtual void ResetObjectLockConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationConfiguration")]
        public virtual void ResetReplicationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestPayer")]
        public virtual void ResetRequestPayer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryptionConfiguration")]
        public virtual void ResetServerSideEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersioning")]
        public virtual void ResetVersioning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsite")]
        public virtual void ResetWebsite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsiteDomain")]
        public virtual void ResetWebsiteDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsiteEndpoint")]
        public virtual void ResetWebsiteEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketRegionalDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketRegionalDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accelerationStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccelerationStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aclInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AclInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketCorsRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketCorsRule[]? CorsRuleInput
        {
            get => GetInstanceProperty<aws.IS3BucketCorsRule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ForceDestroyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketGrant\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketGrant[]? GrantInput
        {
            get => GetInstanceProperty<aws.IS3BucketGrant[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostedZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleRuleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketLifecycleRule[]? LifecycleRuleInput
        {
            get => GetInstanceProperty<aws.IS3BucketLifecycleRule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLogging\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketLogging[]? LoggingInput
        {
            get => GetInstanceProperty<aws.IS3BucketLogging[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLockConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketObjectLockConfiguration[]? ObjectLockConfigurationInput
        {
            get => GetInstanceProperty<aws.IS3BucketObjectLockConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketReplicationConfiguration[]? ReplicationConfigurationInput
        {
            get => GetInstanceProperty<aws.IS3BucketReplicationConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestPayerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestPayerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketServerSideEncryptionConfiguration[]? ServerSideEncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.IS3BucketServerSideEncryptionConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versioningInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketVersioning\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketVersioning[]? VersioningInput
        {
            get => GetInstanceProperty<aws.IS3BucketVersioning[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebsiteDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebsiteEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketWebsite\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketWebsite[]? WebsiteInput
        {
            get => GetInstanceProperty<aws.IS3BucketWebsite[]?>();
        }

        [JsiiProperty(name: "accelerationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccelerationStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Acl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketCorsRule\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketCorsRule[] CorsRule
        {
            get => GetInstanceProperty<aws.IS3BucketCorsRule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ForceDestroy
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grant", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketGrant\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketGrant[] Grant
        {
            get => GetInstanceProperty<aws.IS3BucketGrant[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRule\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketLifecycleRule[] LifecycleRule
        {
            get => GetInstanceProperty<aws.IS3BucketLifecycleRule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLogging\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketLogging[] Logging
        {
            get => GetInstanceProperty<aws.IS3BucketLogging[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectLockConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketObjectLockConfiguration[] ObjectLockConfiguration
        {
            get => GetInstanceProperty<aws.IS3BucketObjectLockConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketReplicationConfiguration[] ReplicationConfiguration
        {
            get => GetInstanceProperty<aws.IS3BucketReplicationConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestPayer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestPayer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketServerSideEncryptionConfiguration[] ServerSideEncryptionConfiguration
        {
            get => GetInstanceProperty<aws.IS3BucketServerSideEncryptionConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versioning", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketVersioning\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketVersioning[] Versioning
        {
            get => GetInstanceProperty<aws.IS3BucketVersioning[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "website", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketWebsite\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketWebsite[] Website
        {
            get => GetInstanceProperty<aws.IS3BucketWebsite[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

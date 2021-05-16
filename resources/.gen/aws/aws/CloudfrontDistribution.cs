using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontDistribution), fullyQualifiedName: "aws.CloudfrontDistribution", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CloudfrontDistributionConfig\"}}]")]
    public class CloudfrontDistribution : HashiCorp.Cdktf.TerraformResource
    {
        public CloudfrontDistribution(Constructs.Construct scope, string id, aws.ICloudfrontDistributionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistribution(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistribution(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "activeTrustedSigners", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string ActiveTrustedSigners(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "resetAliases")]
        public virtual void ResetAliases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheBehavior")]
        public virtual void ResetCacheBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomErrorResponse")]
        public virtual void ResetCustomErrorResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultRootObject")]
        public virtual void ResetDefaultRootObject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpVersion")]
        public virtual void ResetHttpVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsIpv6Enabled")]
        public virtual void ResetIsIpv6Enabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingConfig")]
        public virtual void ResetLoggingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderedCacheBehavior")]
        public virtual void ResetOrderedCacheBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginGroup")]
        public virtual void ResetOriginGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriceClass")]
        public virtual void ResetPriceClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetainOnDelete")]
        public virtual void ResetRetainOnDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForDeployment")]
        public virtual void ResetWaitForDeployment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebAclId")]
        public virtual void ResetWebAclId()
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

        [JsiiProperty(name: "callerReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallerReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultCacheBehaviorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionDefaultCacheBehavior[] DefaultCacheBehaviorInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionDefaultCacheBehavior[]>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabledInput", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnabledInput
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inProgressValidationBatches", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InProgressValidationBatches
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastModifiedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionOrigin[] OriginInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionOrigin[]>()!;
        }

        [JsiiProperty(name: "restrictionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictions\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionRestrictions[] RestrictionsInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionRestrictions[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewerCertificateInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionViewerCertificate\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionViewerCertificate[] ViewerCertificateInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionViewerCertificate[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AliasesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheBehaviorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudfrontDistributionCacheBehavior[]? CacheBehaviorInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionCacheBehavior[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customErrorResponseInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudfrontDistributionCustomErrorResponse[]? CustomErrorResponseInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionCustomErrorResponse[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRootObjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultRootObjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isIpv6EnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? IsIpv6EnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionLoggingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudfrontDistributionLoggingConfig[]? LoggingConfigInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionLoggingConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderedCacheBehaviorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudfrontDistributionOrderedCacheBehavior[]? OrderedCacheBehaviorInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionOrderedCacheBehavior[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICloudfrontDistributionOriginGroup[]? OriginGroupInput
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionOriginGroup[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriceClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainOnDeleteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RetainOnDeleteInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForDeploymentInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? WaitForDeploymentInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAclIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebAclIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Aliases
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionCacheBehavior[] CacheBehavior
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionCacheBehavior[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionCustomErrorResponse[] CustomErrorResponse
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionCustomErrorResponse[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionDefaultCacheBehavior[] DefaultCacheBehavior
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionDefaultCacheBehavior[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRootObject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool IsIpv6Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionLoggingConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionLoggingConfig[] LoggingConfig
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionLoggingConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionOrderedCacheBehavior[] OrderedCacheBehavior
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionOrderedCacheBehavior[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "origin", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionOrigin[] Origin
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionOrigin[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionOriginGroup[] OriginGroup
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionOriginGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriceClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restrictions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictions\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionRestrictions[] Restrictions
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionRestrictions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retainOnDelete", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RetainOnDelete
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionViewerCertificate\"},\"kind\":\"array\"}}")]
        public virtual aws.ICloudfrontDistributionViewerCertificate[] ViewerCertificate
        {
            get => GetInstanceProperty<aws.ICloudfrontDistributionViewerCertificate[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForDeployment", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool WaitForDeployment
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebAclId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

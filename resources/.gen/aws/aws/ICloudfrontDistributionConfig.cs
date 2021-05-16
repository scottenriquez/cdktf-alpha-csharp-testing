using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionConfig), fullyQualifiedName: "aws.CloudfrontDistributionConfig")]
    public interface ICloudfrontDistributionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>default_cache_behavior block.</summary>
        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionDefaultCacheBehavior[] DefaultCacheBehavior
        {
            get;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        /// <summary>origin block.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionOrigin[] Origin
        {
            get;
        }

        /// <summary>restrictions block.</summary>
        [JsiiProperty(name: "restrictions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictions\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionRestrictions[] Restrictions
        {
            get;
        }

        /// <summary>viewer_certificate block.</summary>
        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionViewerCertificate\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionViewerCertificate[] ViewerCertificate
        {
            get;
        }

        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Aliases
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache_behavior block.</summary>
        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionCacheBehavior[]? CacheBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_error_response block.</summary>
        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionCustomErrorResponse[]? CustomErrorResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRootObject
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IsIpv6Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging_config block.</summary>
        [JsiiProperty(name: "loggingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionLoggingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionLoggingConfig[]? LoggingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ordered_cache_behavior block.</summary>
        [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionOrderedCacheBehavior[]? OrderedCacheBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>origin_group block.</summary>
        [JsiiProperty(name: "originGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionOriginGroup[]? OriginGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriceClass
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "retainOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RetainOnDelete
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

        [JsiiProperty(name: "waitForDeployment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? WaitForDeployment
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WebAclId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionConfig), fullyQualifiedName: "aws.CloudfrontDistributionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_cache_behavior block.</summary>
            [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionDefaultCacheBehavior[] DefaultCacheBehavior
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionDefaultCacheBehavior[]>()!;
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            /// <summary>origin block.</summary>
            [JsiiProperty(name: "origin", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionOrigin[] Origin
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOrigin[]>()!;
            }

            /// <summary>restrictions block.</summary>
            [JsiiProperty(name: "restrictions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictions\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionRestrictions[] Restrictions
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionRestrictions[]>()!;
            }

            /// <summary>viewer_certificate block.</summary>
            [JsiiProperty(name: "viewerCertificate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionViewerCertificate\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionViewerCertificate[] ViewerCertificate
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionViewerCertificate[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Aliases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>cache_behavior block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionCacheBehavior[]? CacheBehavior
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionCacheBehavior[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>custom_error_response block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customErrorResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionCustomErrorResponse[]? CustomErrorResponse
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionCustomErrorResponse[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRootObject
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IsIpv6Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>logging_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loggingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionLoggingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionLoggingConfig[]? LoggingConfig
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionLoggingConfig[]?>();
            }

            /// <summary>ordered_cache_behavior block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionOrderedCacheBehavior[]? OrderedCacheBehavior
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOrderedCacheBehavior[]?>();
            }

            /// <summary>origin_group block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionOriginGroup[]? OriginGroup
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOriginGroup[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriceClass
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "retainOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RetainOnDelete
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "waitForDeployment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? WaitForDeployment
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WebAclId
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

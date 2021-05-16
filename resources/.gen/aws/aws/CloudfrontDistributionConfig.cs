using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionConfig")]
    public class CloudfrontDistributionConfig : aws.ICloudfrontDistributionConfig
    {
        /// <summary>default_cache_behavior block.</summary>
        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehavior\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionDefaultCacheBehavior[] DefaultCacheBehavior
        {
            get;
            set;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>origin block.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionOrigin[] Origin
        {
            get;
            set;
        }

        /// <summary>restrictions block.</summary>
        [JsiiProperty(name: "restrictions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictions\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionRestrictions[] Restrictions
        {
            get;
            set;
        }

        /// <summary>viewer_certificate block.</summary>
        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionViewerCertificate\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionViewerCertificate[] ViewerCertificate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Aliases
        {
            get;
            set;
        }

        /// <summary>cache_behavior block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionCacheBehavior[]? CacheBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Comment
        {
            get;
            set;
        }

        /// <summary>custom_error_response block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionCustomErrorResponse[]? CustomErrorResponse
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultRootObject
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HttpVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IsIpv6Enabled
        {
            get;
            set;
        }

        /// <summary>logging_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionLoggingConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionLoggingConfig[]? LoggingConfig
        {
            get;
            set;
        }

        /// <summary>ordered_cache_behavior block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionOrderedCacheBehavior[]? OrderedCacheBehavior
        {
            get;
            set;
        }

        /// <summary>origin_group block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionOriginGroup[]? OriginGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PriceClass
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RetainOnDelete
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
        [JsiiProperty(name: "waitForDeployment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? WaitForDeployment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WebAclId
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

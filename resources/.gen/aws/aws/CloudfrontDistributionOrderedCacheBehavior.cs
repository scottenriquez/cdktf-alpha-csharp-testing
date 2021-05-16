using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOrderedCacheBehavior")]
    public class CloudfrontDistributionOrderedCacheBehavior : aws.ICloudfrontDistributionOrderedCacheBehavior
    {
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] AllowedMethods
        {
            get;
            set;
        }

        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CachedMethods
        {
            get;
            set;
        }

        /// <summary>forwarded_values block.</summary>
        [JsiiProperty(name: "forwardedValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValues\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues[] ForwardedValues
        {
            get;
            set;
        }

        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PathPattern
        {
            get;
            set;
        }

        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TargetOriginId
        {
            get;
            set;
        }

        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ViewerProtocolPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Compress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DefaultTtl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FieldLevelEncryptionId
        {
            get;
            set;
        }

        /// <summary>lambda_function_association block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionOrderedCacheBehaviorLambdaFunctionAssociation[]? LambdaFunctionAssociation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxTtl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinTtl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "smoothStreaming", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SmoothStreaming
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? TrustedSigners
        {
            get;
            set;
        }
    }
}

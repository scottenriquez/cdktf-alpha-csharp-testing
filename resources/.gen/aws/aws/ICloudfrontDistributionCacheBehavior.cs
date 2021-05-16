using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionCacheBehavior), fullyQualifiedName: "aws.CloudfrontDistributionCacheBehavior")]
    public interface ICloudfrontDistributionCacheBehavior
    {
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMethods
        {
            get;
        }

        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CachedMethods
        {
            get;
        }

        /// <summary>forwarded_values block.</summary>
        [JsiiProperty(name: "forwardedValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehaviorForwardedValues\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionCacheBehaviorForwardedValues[] ForwardedValues
        {
            get;
        }

        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        string PathPattern
        {
            get;
        }

        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetOriginId
        {
            get;
        }

        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string ViewerProtocolPolicy
        {
            get;
        }

        [JsiiProperty(name: "compress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Compress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldLevelEncryptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_association block.</summary>
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation[]? LambdaFunctionAssociation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "smoothStreaming", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SmoothStreaming
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedSigners
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionCacheBehavior), fullyQualifiedName: "aws.CloudfrontDistributionCacheBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionCacheBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CachedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>forwarded_values block.</summary>
            [JsiiProperty(name: "forwardedValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehaviorForwardedValues\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionCacheBehaviorForwardedValues[] ForwardedValues
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionCacheBehaviorForwardedValues[]>()!;
            }

            [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
            public string PathPattern
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetOriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string ViewerProtocolPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "compress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Compress
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultTtl
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldLevelEncryptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_function_association block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation[]? LambdaFunctionAssociation
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTtl
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinTtl
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "smoothStreaming", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SmoothStreaming
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedSigners
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

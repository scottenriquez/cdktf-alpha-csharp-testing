using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehaviorForwardedValues), fullyQualifiedName: "aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValues")]
    public interface ICloudfrontDistributionOrderedCacheBehaviorForwardedValues
    {
        /// <summary>cookies block.</summary>
        [JsiiProperty(name: "cookies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies[] Cookies
        {
            get;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"boolean\"}")]
        bool QueryString
        {
            get;
        }

        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Headers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? QueryStringCacheKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOrderedCacheBehaviorForwardedValues), fullyQualifiedName: "aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValues")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cookies block.</summary>
            [JsiiProperty(name: "cookies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies[] Cookies
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies[]>()!;
            }

            [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool QueryString
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Headers
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? QueryStringCacheKeys
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

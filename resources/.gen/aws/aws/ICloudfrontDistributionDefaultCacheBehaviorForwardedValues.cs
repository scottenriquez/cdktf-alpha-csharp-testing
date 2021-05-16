using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionDefaultCacheBehaviorForwardedValues), fullyQualifiedName: "aws.CloudfrontDistributionDefaultCacheBehaviorForwardedValues")]
    public interface ICloudfrontDistributionDefaultCacheBehaviorForwardedValues
    {
        /// <summary>cookies block.</summary>
        [JsiiProperty(name: "cookies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies[] Cookies
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

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionDefaultCacheBehaviorForwardedValues), fullyQualifiedName: "aws.CloudfrontDistributionDefaultCacheBehaviorForwardedValues")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cookies block.</summary>
            [JsiiProperty(name: "cookies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies[] Cookies
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies[]>()!;
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

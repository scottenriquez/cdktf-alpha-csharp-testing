using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValues")]
    public class CloudfrontDistributionOrderedCacheBehaviorForwardedValues : aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues
    {
        /// <summary>cookies block.</summary>
        [JsiiProperty(name: "cookies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies[] Cookies
        {
            get;
            set;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool QueryString
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Headers
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? QueryStringCacheKeys
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies")]
    public class CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies : aws.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies
    {
        [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Forward
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? WhitelistedNames
        {
            get;
            set;
        }
    }
}

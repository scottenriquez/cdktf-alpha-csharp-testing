using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionCustomErrorResponse")]
    public class CloudfrontDistributionCustomErrorResponse : aws.ICloudfrontDistributionCustomErrorResponse
    {
        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ErrorCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ErrorCachingMinTtl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ResponseCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResponsePagePath
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3BucketLifecycleRuleExpiration")]
    public class S3BucketLifecycleRuleExpiration : aws.IS3BucketLifecycleRuleExpiration
    {
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Date
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Days
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiredObjectDeleteMarker", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ExpiredObjectDeleteMarker
        {
            get;
            set;
        }
    }
}

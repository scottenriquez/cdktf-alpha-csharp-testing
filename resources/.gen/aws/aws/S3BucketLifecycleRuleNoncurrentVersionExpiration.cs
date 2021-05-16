using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
    public class S3BucketLifecycleRuleNoncurrentVersionExpiration : aws.IS3BucketLifecycleRuleNoncurrentVersionExpiration
    {
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Days
        {
            get;
            set;
        }
    }
}

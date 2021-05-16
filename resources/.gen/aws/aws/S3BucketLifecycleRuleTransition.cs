using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketLifecycleRuleTransition")]
    public class S3BucketLifecycleRuleTransition : aws.IS3BucketLifecycleRuleTransition
    {
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StorageClass
        {
            get;
            set;
        }

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
    }
}

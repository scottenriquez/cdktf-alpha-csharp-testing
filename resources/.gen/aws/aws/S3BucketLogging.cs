using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketLogging")]
    public class S3BucketLogging : aws.IS3BucketLogging
    {
        [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TargetBucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetPrefix
        {
            get;
            set;
        }
    }
}

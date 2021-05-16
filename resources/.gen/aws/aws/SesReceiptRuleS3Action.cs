using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesReceiptRuleS3Action")]
    public class SesReceiptRuleS3Action : aws.ISesReceiptRuleS3Action
    {
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketName
        {
            get;
            set;
        }

        [JsiiProperty(name: "position", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Position
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectKeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ObjectKeyPrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TopicArn
        {
            get;
            set;
        }
    }
}

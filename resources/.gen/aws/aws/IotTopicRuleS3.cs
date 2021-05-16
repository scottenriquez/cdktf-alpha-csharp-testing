using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleS3")]
    public class IotTopicRuleS3 : aws.IIotTopicRuleS3
    {
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BucketName
        {
            get;
            set;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Key
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }
    }
}

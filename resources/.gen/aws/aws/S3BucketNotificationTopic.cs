using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketNotificationTopic")]
    public class S3BucketNotificationTopic : aws.IS3BucketNotificationTopic
    {
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Events
        {
            get;
            set;
        }

        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TopicArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FilterPrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FilterSuffix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Id
        {
            get;
            set;
        }
    }
}

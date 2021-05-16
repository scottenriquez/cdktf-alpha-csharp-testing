using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleElasticsearch")]
    public class IotTopicRuleElasticsearch : aws.IIotTopicRuleElasticsearch
    {
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Endpoint
        {
            get;
            set;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Id
        {
            get;
            set;
        }

        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Index
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }
    }
}

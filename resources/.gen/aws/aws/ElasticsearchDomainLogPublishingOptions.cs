using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticsearchDomainLogPublishingOptions")]
    public class ElasticsearchDomainLogPublishingOptions : aws.IElasticsearchDomainLogPublishingOptions
    {
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CloudwatchLogGroupArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }
    }
}

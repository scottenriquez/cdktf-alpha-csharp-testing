using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionIotAnalytics")]
    public class IotTopicRuleErrorActionIotAnalytics : aws.IIotTopicRuleErrorActionIotAnalytics
    {
        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ChannelName
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

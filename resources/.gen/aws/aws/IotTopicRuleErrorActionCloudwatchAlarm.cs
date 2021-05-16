using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionCloudwatchAlarm")]
    public class IotTopicRuleErrorActionCloudwatchAlarm : aws.IIotTopicRuleErrorActionCloudwatchAlarm
    {
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AlarmName
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

        [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StateReason
        {
            get;
            set;
        }

        [JsiiProperty(name: "stateValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StateValue
        {
            get;
            set;
        }
    }
}

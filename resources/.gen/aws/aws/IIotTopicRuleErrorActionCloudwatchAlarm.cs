using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchAlarm), fullyQualifiedName: "aws.IotTopicRuleErrorActionCloudwatchAlarm")]
    public interface IIotTopicRuleErrorActionCloudwatchAlarm
    {
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmName
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}")]
        string StateReason
        {
            get;
        }

        [JsiiProperty(name: "stateValue", typeJson: "{\"primitive\":\"string\"}")]
        string StateValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionCloudwatchAlarm), fullyQualifiedName: "aws.IotTopicRuleErrorActionCloudwatchAlarm")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionCloudwatchAlarm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stateReason", typeJson: "{\"primitive\":\"string\"}")]
            public string StateReason
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stateValue", typeJson: "{\"primitive\":\"string\"}")]
            public string StateValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

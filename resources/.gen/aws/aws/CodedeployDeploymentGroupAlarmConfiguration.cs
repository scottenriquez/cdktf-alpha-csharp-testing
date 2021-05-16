using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupAlarmConfiguration")]
    public class CodedeployDeploymentGroupAlarmConfiguration : aws.ICodedeployDeploymentGroupAlarmConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Alarms
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

        [JsiiOptional]
        [JsiiProperty(name: "ignorePollAlarmFailure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IgnorePollAlarmFailure
        {
            get;
            set;
        }
    }
}

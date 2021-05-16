using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupTriggerConfiguration")]
    public class CodedeployDeploymentGroupTriggerConfiguration : aws.ICodedeployDeploymentGroupTriggerConfiguration
    {
        [JsiiProperty(name: "triggerEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] TriggerEvents
        {
            get;
            set;
        }

        [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TriggerName
        {
            get;
            set;
        }

        [JsiiProperty(name: "triggerTargetArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TriggerTargetArn
        {
            get;
            set;
        }
    }
}

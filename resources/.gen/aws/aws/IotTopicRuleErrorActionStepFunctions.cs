using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionStepFunctions")]
    public class IotTopicRuleErrorActionStepFunctions : aws.IIotTopicRuleErrorActionStepFunctions
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "stateMachineName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StateMachineName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExecutionNamePrefix
        {
            get;
            set;
        }
    }
}

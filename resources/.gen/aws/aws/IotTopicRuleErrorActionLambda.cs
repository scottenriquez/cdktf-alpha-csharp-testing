using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionLambda")]
    public class IotTopicRuleErrorActionLambda : aws.IIotTopicRuleErrorActionLambda
    {
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FunctionArn
        {
            get;
            set;
        }
    }
}

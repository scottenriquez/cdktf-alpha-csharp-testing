using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption : aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption
    {
        [JsiiOptional]
        [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ActionOnTimeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WaitTimeInMinutes
        {
            get;
            set;
        }
    }
}

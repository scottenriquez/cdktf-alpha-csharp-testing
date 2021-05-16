using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption : aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption
    {
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}

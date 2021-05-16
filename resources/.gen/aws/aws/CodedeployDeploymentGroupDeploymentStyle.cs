using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupDeploymentStyle")]
    public class CodedeployDeploymentGroupDeploymentStyle : aws.ICodedeployDeploymentGroupDeploymentStyle
    {
        [JsiiOptional]
        [JsiiProperty(name: "deploymentOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeploymentOption
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeploymentType
        {
            get;
            set;
        }
    }
}

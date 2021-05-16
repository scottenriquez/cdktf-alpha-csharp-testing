using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentConfigMinimumHealthyHosts")]
    public class CodedeployDeploymentConfigMinimumHealthyHosts : aws.ICodedeployDeploymentConfigMinimumHealthyHosts
    {
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Value
        {
            get;
            set;
        }
    }
}

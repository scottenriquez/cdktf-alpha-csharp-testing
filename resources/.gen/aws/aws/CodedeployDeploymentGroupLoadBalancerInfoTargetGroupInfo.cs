using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo : aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo
    {
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute : aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
    {
        [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] ListenerArns
        {
            get;
            set;
        }
    }
}

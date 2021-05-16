using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupLoadBalancerInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfo : aws.ICodedeployDeploymentGroupLoadBalancerInfo
    {
        /// <summary>elb_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elbInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo[]? ElbInfo
        {
            get;
            set;
        }

        /// <summary>target_group_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo[]? TargetGroupInfo
        {
            get;
            set;
        }

        /// <summary>target_group_pair_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo[]? TargetGroupPairInfo
        {
            get;
            set;
        }
    }
}

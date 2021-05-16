using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo : aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo
    {
        /// <summary>prod_traffic_route block.</summary>
        [JsiiProperty(name: "prodTrafficRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute[] ProdTrafficRoute
        {
            get;
            set;
        }

        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup[] TargetGroup
        {
            get;
            set;
        }

        /// <summary>test_traffic_route block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "testTrafficRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute[]? TestTrafficRoute
        {
            get;
            set;
        }
    }
}

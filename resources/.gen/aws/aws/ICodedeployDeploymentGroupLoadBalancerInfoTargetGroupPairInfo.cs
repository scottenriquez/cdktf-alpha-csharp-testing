using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo
    {
        /// <summary>prod_traffic_route block.</summary>
        [JsiiProperty(name: "prodTrafficRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"},\"kind\":\"array\"}}")]
        aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute[] ProdTrafficRoute
        {
            get;
        }

        /// <summary>target_group block.</summary>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}")]
        aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup[] TargetGroup
        {
            get;
        }

        /// <summary>test_traffic_route block.</summary>
        [JsiiProperty(name: "testTrafficRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute[]? TestTrafficRoute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>prod_traffic_route block.</summary>
            [JsiiProperty(name: "prodTrafficRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"},\"kind\":\"array\"}}")]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute[] ProdTrafficRoute
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute[]>()!;
            }

            /// <summary>target_group block.</summary>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}")]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup[] TargetGroup
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup[]>()!;
            }

            /// <summary>test_traffic_route block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "testTrafficRoute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute[]? TestTrafficRoute
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute[]?>();
            }
        }
    }
}

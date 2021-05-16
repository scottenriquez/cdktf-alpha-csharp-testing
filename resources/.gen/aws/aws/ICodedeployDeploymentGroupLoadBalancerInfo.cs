using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfo")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfo
    {
        /// <summary>elb_info block.</summary>
        [JsiiProperty(name: "elbInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo[]? ElbInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_group_info block.</summary>
        [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo[]? TargetGroupInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_group_pair_info block.</summary>
        [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo[]? TargetGroupPairInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfo")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupLoadBalancerInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>elb_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elbInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo[]? ElbInfo
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo[]?>();
            }

            /// <summary>target_group_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo[]? TargetGroupInfo
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo[]?>();
            }

            /// <summary>target_group_pair_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo[]? TargetGroupPairInfo
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo[]?>();
            }
        }
    }
}

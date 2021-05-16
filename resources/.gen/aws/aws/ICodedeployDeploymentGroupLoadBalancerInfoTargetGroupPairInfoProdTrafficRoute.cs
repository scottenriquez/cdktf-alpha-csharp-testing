using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
    {
        [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ListenerArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ListenerArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

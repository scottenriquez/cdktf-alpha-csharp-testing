using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

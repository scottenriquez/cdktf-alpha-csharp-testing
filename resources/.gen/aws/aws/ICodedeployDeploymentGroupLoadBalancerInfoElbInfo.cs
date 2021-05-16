using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoElbInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoElbInfo")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoElbInfo
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

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoElbInfo), fullyQualifiedName: "aws.CodedeployDeploymentGroupLoadBalancerInfoElbInfo")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo
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

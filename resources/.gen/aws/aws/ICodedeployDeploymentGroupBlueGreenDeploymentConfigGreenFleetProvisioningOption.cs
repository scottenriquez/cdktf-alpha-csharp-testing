using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption), fullyQualifiedName: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption
    {
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption), fullyQualifiedName: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

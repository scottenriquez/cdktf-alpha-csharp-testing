using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupDeploymentStyle), fullyQualifiedName: "aws.CodedeployDeploymentGroupDeploymentStyle")]
    public interface ICodedeployDeploymentGroupDeploymentStyle
    {
        [JsiiProperty(name: "deploymentOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentOption
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupDeploymentStyle), fullyQualifiedName: "aws.CodedeployDeploymentGroupDeploymentStyle")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupDeploymentStyle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentOption
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption), fullyQualifiedName: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption
    {
        [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WaitTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption), fullyQualifiedName: "aws.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WaitTimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

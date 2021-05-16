using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfig), fullyQualifiedName: "aws.CodedeployDeploymentConfigTrafficRoutingConfig")]
    public interface ICodedeployDeploymentConfigTrafficRoutingConfig
    {
        /// <summary>time_based_canary block.</summary>
        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary[]? TimeBasedCanary
        {
            get
            {
                return null;
            }
        }

        /// <summary>time_based_linear block.</summary>
        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear[]? TimeBasedLinear
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfig), fullyQualifiedName: "aws.CodedeployDeploymentConfigTrafficRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentConfigTrafficRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>time_based_canary block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary[]? TimeBasedCanary
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary[]?>();
            }

            /// <summary>time_based_linear block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear[]? TimeBasedLinear
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

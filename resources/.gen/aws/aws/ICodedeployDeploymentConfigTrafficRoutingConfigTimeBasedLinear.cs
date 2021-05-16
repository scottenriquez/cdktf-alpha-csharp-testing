using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear), fullyQualifiedName: "aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear")]
    public interface ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear
    {
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Interval
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Percentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear), fullyQualifiedName: "aws.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Interval
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Percentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

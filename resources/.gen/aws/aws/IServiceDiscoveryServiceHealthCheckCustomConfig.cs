using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IServiceDiscoveryServiceHealthCheckCustomConfig), fullyQualifiedName: "aws.ServiceDiscoveryServiceHealthCheckCustomConfig")]
    public interface IServiceDiscoveryServiceHealthCheckCustomConfig
    {
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceDiscoveryServiceHealthCheckCustomConfig), fullyQualifiedName: "aws.ServiceDiscoveryServiceHealthCheckCustomConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IServiceDiscoveryServiceHealthCheckCustomConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

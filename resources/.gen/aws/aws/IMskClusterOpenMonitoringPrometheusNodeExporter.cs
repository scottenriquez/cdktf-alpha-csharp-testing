using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoringPrometheusNodeExporter), fullyQualifiedName: "aws.MskClusterOpenMonitoringPrometheusNodeExporter")]
    public interface IMskClusterOpenMonitoringPrometheusNodeExporter
    {
        [JsiiProperty(name: "enabledInBroker", typeJson: "{\"primitive\":\"boolean\"}")]
        bool EnabledInBroker
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoringPrometheusNodeExporter), fullyQualifiedName: "aws.MskClusterOpenMonitoringPrometheusNodeExporter")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterOpenMonitoringPrometheusNodeExporter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabledInBroker", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool EnabledInBroker
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}

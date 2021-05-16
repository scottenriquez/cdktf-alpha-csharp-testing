using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoring), fullyQualifiedName: "aws.MskClusterOpenMonitoring")]
    public interface IMskClusterOpenMonitoring
    {
        /// <summary>prometheus block.</summary>
        [JsiiProperty(name: "prometheus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheus\"},\"kind\":\"array\"}}")]
        aws.IMskClusterOpenMonitoringPrometheus[] Prometheus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoring), fullyQualifiedName: "aws.MskClusterOpenMonitoring")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterOpenMonitoring
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>prometheus block.</summary>
            [JsiiProperty(name: "prometheus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheus\"},\"kind\":\"array\"}}")]
            public aws.IMskClusterOpenMonitoringPrometheus[] Prometheus
            {
                get => GetInstanceProperty<aws.IMskClusterOpenMonitoringPrometheus[]>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterOpenMonitoringPrometheus), fullyQualifiedName: "aws.MskClusterOpenMonitoringPrometheus")]
    public interface IMskClusterOpenMonitoringPrometheus
    {
        /// <summary>jmx_exporter block.</summary>
        [JsiiProperty(name: "jmxExporter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheusJmxExporter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterOpenMonitoringPrometheusJmxExporter[]? JmxExporter
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_exporter block.</summary>
        [JsiiProperty(name: "nodeExporter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheusNodeExporter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterOpenMonitoringPrometheusNodeExporter[]? NodeExporter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterOpenMonitoringPrometheus), fullyQualifiedName: "aws.MskClusterOpenMonitoringPrometheus")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterOpenMonitoringPrometheus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>jmx_exporter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jmxExporter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheusJmxExporter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterOpenMonitoringPrometheusJmxExporter[]? JmxExporter
            {
                get => GetInstanceProperty<aws.IMskClusterOpenMonitoringPrometheusJmxExporter[]?>();
            }

            /// <summary>node_exporter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeExporter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheusNodeExporter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterOpenMonitoringPrometheusNodeExporter[]? NodeExporter
            {
                get => GetInstanceProperty<aws.IMskClusterOpenMonitoringPrometheusNodeExporter[]?>();
            }
        }
    }
}

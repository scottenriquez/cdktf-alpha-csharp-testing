using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MskClusterOpenMonitoringPrometheus")]
    public class MskClusterOpenMonitoringPrometheus : aws.IMskClusterOpenMonitoringPrometheus
    {
        /// <summary>jmx_exporter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jmxExporter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheusJmxExporter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterOpenMonitoringPrometheusJmxExporter[]? JmxExporter
        {
            get;
            set;
        }

        /// <summary>node_exporter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeExporter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheusNodeExporter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterOpenMonitoringPrometheusNodeExporter[]? NodeExporter
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterOpenMonitoring")]
    public class MskClusterOpenMonitoring : aws.IMskClusterOpenMonitoring
    {
        /// <summary>prometheus block.</summary>
        [JsiiProperty(name: "prometheus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterOpenMonitoringPrometheus\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IMskClusterOpenMonitoringPrometheus[] Prometheus
        {
            get;
            set;
        }
    }
}

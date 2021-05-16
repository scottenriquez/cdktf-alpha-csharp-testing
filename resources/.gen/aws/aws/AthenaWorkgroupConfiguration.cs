using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AthenaWorkgroupConfiguration")]
    public class AthenaWorkgroupConfiguration : aws.IAthenaWorkgroupConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BytesScannedCutoffPerQuery
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnforceWorkgroupConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PublishCloudwatchMetricsEnabled
        {
            get;
            set;
        }

        /// <summary>result_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AthenaWorkgroupConfigurationResultConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAthenaWorkgroupConfigurationResultConfiguration[]? ResultConfiguration
        {
            get;
            set;
        }
    }
}

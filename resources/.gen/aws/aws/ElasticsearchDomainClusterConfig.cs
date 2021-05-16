using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElasticsearchDomainClusterConfig")]
    public class ElasticsearchDomainClusterConfig : aws.IElasticsearchDomainClusterConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DedicatedMasterCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DedicatedMasterEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DedicatedMasterType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WarmCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? WarmEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WarmType
        {
            get;
            set;
        }

        /// <summary>zone_awareness_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainClusterConfigZoneAwarenessConfig[]? ZoneAwarenessConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ZoneAwarenessEnabled
        {
            get;
            set;
        }
    }
}

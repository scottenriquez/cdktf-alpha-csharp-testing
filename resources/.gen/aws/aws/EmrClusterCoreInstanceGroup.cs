using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EmrClusterCoreInstanceGroup")]
    public class EmrClusterCoreInstanceGroup : aws.IEmrClusterCoreInstanceGroup
    {
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AutoscalingPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BidPrice
        {
            get;
            set;
        }

        /// <summary>ebs_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterCoreInstanceGroupEbsConfig[]? EbsConfig
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
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AutoscalingGroupMixedInstancesPolicyInstancesDistribution")]
    public class AutoscalingGroupMixedInstancesPolicyInstancesDistribution : aws.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution
    {
        [JsiiOptional]
        [JsiiProperty(name: "onDemandAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnDemandAllocationStrategy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? OnDemandBaseCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandPercentageAboveBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? OnDemandPercentageAboveBaseCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotAllocationStrategy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotInstancePools", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SpotInstancePools
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotMaxPrice
        {
            get;
            set;
        }
    }
}

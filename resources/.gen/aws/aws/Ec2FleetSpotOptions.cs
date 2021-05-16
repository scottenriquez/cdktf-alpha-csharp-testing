using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Ec2FleetSpotOptions")]
    public class Ec2FleetSpotOptions : aws.IEc2FleetSpotOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInterruptionBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? InstancePoolsToUseCount
        {
            get;
            set;
        }
    }
}

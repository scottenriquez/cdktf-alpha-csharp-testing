using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Ec2FleetOnDemandOptions")]
    public class Ec2FleetOnDemandOptions : aws.IEc2FleetOnDemandOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AllocationStrategy
        {
            get;
            set;
        }
    }
}

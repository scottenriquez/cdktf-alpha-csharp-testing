using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2FleetTargetCapacitySpecification")]
    public class Ec2FleetTargetCapacitySpecification : aws.IEc2FleetTargetCapacitySpecification
    {
        [JsiiProperty(name: "defaultTargetCapacityType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultTargetCapacityType
        {
            get;
            set;
        }

        [JsiiProperty(name: "totalTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TotalTargetCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? OnDemandTargetCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotTargetCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SpotTargetCapacity
        {
            get;
            set;
        }
    }
}

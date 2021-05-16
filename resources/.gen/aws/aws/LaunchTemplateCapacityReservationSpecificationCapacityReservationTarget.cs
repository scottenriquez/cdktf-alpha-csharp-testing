using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget")]
    public class LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget : aws.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget
    {
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateCapacityReservationSpecification")]
    public class LaunchTemplateCapacityReservationSpecification : aws.ILaunchTemplateCapacityReservationSpecification
    {
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CapacityReservationPreference
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget[]? CapacityReservationTarget
        {
            get;
            set;
        }
    }
}

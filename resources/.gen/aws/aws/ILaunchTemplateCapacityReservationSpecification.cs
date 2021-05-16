using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateCapacityReservationSpecification), fullyQualifiedName: "aws.LaunchTemplateCapacityReservationSpecification")]
    public interface ILaunchTemplateCapacityReservationSpecification
    {
        [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity_reservation_target block.</summary>
        [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget[]? CapacityReservationTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateCapacityReservationSpecification), fullyQualifiedName: "aws.LaunchTemplateCapacityReservationSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateCapacityReservationSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>capacity_reservation_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget[]? CapacityReservationTarget
            {
                get => GetInstanceProperty<aws.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget[]?>();
            }
        }
    }
}

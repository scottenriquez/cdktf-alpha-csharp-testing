using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget")]
    public interface ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget
    {
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget), fullyQualifiedName: "aws.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateCapacityReservationSpecificationCapacityReservationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

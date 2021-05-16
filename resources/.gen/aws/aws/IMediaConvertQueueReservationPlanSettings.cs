using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMediaConvertQueueReservationPlanSettings), fullyQualifiedName: "aws.MediaConvertQueueReservationPlanSettings")]
    public interface IMediaConvertQueueReservationPlanSettings
    {
        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
        string Commitment
        {
            get;
        }

        [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}")]
        string RenewalType
        {
            get;
        }

        [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}")]
        double ReservedSlots
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMediaConvertQueueReservationPlanSettings), fullyQualifiedName: "aws.MediaConvertQueueReservationPlanSettings")]
        internal sealed class _Proxy : DeputyBase, aws.IMediaConvertQueueReservationPlanSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
            public string Commitment
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}")]
            public string RenewalType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}")]
            public double ReservedSlots
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

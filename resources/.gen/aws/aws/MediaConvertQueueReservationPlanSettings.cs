using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MediaConvertQueueReservationPlanSettings")]
    public class MediaConvertQueueReservationPlanSettings : aws.IMediaConvertQueueReservationPlanSettings
    {
        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Commitment
        {
            get;
            set;
        }

        [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RenewalType
        {
            get;
            set;
        }

        [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ReservedSlots
        {
            get;
            set;
        }
    }
}

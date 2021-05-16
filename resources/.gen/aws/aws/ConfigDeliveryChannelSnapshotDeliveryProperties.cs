using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ConfigDeliveryChannelSnapshotDeliveryProperties")]
    public class ConfigDeliveryChannelSnapshotDeliveryProperties : aws.IConfigDeliveryChannelSnapshotDeliveryProperties
    {
        [JsiiOptional]
        [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeliveryFrequency
        {
            get;
            set;
        }
    }
}

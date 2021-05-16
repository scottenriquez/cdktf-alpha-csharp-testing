using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigDeliveryChannelSnapshotDeliveryProperties), fullyQualifiedName: "aws.ConfigDeliveryChannelSnapshotDeliveryProperties")]
    public interface IConfigDeliveryChannelSnapshotDeliveryProperties
    {
        [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryFrequency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigDeliveryChannelSnapshotDeliveryProperties), fullyQualifiedName: "aws.ConfigDeliveryChannelSnapshotDeliveryProperties")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigDeliveryChannelSnapshotDeliveryProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryFrequency
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

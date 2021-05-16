using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration
    {
        [JsiiProperty(name: "kinesisStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string KinesisStreamArn
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "kinesisStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KinesisStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

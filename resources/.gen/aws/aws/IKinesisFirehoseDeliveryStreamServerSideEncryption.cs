using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamServerSideEncryption), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamServerSideEncryption")]
    public interface IKinesisFirehoseDeliveryStreamServerSideEncryption
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamServerSideEncryption), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamServerSideEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamServerSideEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}

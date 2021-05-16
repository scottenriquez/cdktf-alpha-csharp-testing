using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationOutputsKinesisFirehose), fullyQualifiedName: "aws.KinesisAnalyticsApplicationOutputsKinesisFirehose")]
    public interface IKinesisAnalyticsApplicationOutputsKinesisFirehose
    {
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationOutputsKinesisFirehose), fullyQualifiedName: "aws.KinesisAnalyticsApplicationOutputsKinesisFirehose")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationOutputsKinesisFirehose
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
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

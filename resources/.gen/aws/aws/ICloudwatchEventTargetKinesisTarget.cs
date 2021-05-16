using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetKinesisTarget), fullyQualifiedName: "aws.CloudwatchEventTargetKinesisTarget")]
    public interface ICloudwatchEventTargetKinesisTarget
    {
        [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartitionKeyPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetKinesisTarget), fullyQualifiedName: "aws.CloudwatchEventTargetKinesisTarget")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchEventTargetKinesisTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartitionKeyPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

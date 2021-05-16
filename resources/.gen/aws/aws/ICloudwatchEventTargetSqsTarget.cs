using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetSqsTarget), fullyQualifiedName: "aws.CloudwatchEventTargetSqsTarget")]
    public interface ICloudwatchEventTargetSqsTarget
    {
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetSqsTarget), fullyQualifiedName: "aws.CloudwatchEventTargetSqsTarget")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchEventTargetSqsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

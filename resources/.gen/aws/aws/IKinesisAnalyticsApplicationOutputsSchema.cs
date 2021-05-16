using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationOutputsSchema), fullyQualifiedName: "aws.KinesisAnalyticsApplicationOutputsSchema")]
    public interface IKinesisAnalyticsApplicationOutputsSchema
    {
        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordFormatType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationOutputsSchema), fullyQualifiedName: "aws.KinesisAnalyticsApplicationOutputsSchema")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationOutputsSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordFormatType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

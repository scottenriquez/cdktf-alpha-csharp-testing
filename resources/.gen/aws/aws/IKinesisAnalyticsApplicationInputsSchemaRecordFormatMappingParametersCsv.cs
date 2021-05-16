using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv
    {
        [JsiiProperty(name: "recordColumnDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        string RecordColumnDelimiter
        {
            get;
        }

        [JsiiProperty(name: "recordRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        string RecordRowDelimiter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "recordColumnDelimiter", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordColumnDelimiter
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "recordRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordRowDelimiter
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

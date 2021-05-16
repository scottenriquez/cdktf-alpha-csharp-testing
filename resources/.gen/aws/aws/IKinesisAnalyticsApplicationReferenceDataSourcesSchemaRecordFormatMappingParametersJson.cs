using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson
    {
        [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
        string RecordRowPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordRowPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

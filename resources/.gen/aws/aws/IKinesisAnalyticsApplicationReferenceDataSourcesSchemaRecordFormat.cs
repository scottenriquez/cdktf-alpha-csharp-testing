using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters[]? MappingParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mapping_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mappingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters[]? MappingParameters
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters[]?>();
            }
        }
    }
}

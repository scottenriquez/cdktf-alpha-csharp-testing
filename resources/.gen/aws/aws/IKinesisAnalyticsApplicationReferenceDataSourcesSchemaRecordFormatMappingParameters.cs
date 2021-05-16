using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        [JsiiProperty(name: "csv", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv[]? Csv
        {
            get
            {
                return null;
            }
        }

        /// <summary>json block.</summary>
        [JsiiProperty(name: "json", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson[]? Json
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>csv block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "csv", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv[]? Csv
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv[]?>();
            }

            /// <summary>json block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "json", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson[]? Json
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson[]?>();
            }
        }
    }
}

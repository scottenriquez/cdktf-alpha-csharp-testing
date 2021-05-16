using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchema), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchema
    {
        /// <summary>record_columns block.</summary>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns[] RecordColumns
        {
            get;
        }

        /// <summary>record_format block.</summary>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat[] RecordFormat
        {
            get;
        }

        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordEncoding
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchema), fullyQualifiedName: "aws.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>record_columns block.</summary>
            [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns[] RecordColumns
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns[]>()!;
            }

            /// <summary>record_format block.</summary>
            [JsiiProperty(name: "recordFormat", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat[] RecordFormat
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordEncoding
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

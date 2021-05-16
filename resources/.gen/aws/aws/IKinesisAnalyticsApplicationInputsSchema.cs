using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchema), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchema")]
    public interface IKinesisAnalyticsApplicationInputsSchema
    {
        /// <summary>record_columns block.</summary>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordColumns\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[] RecordColumns
        {
            get;
        }

        /// <summary>record_format block.</summary>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormat\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormat[] RecordFormat
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

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchema), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchema")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>record_columns block.</summary>
            [JsiiProperty(name: "recordColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordColumns\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[] RecordColumns
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsSchemaRecordColumns[]>()!;
            }

            /// <summary>record_format block.</summary>
            [JsiiProperty(name: "recordFormat", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormat\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormat[] RecordFormat
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormat[]>()!;
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

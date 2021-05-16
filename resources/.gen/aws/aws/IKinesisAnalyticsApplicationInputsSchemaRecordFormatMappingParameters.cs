using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        [JsiiProperty(name: "csv", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv[]? Csv
        {
            get
            {
                return null;
            }
        }

        /// <summary>json block.</summary>
        [JsiiProperty(name: "json", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson[]? Json
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>csv block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "csv", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv[]? Csv
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv[]?>();
            }

            /// <summary>json block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "json", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson[]? Json
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson[]?>();
            }
        }
    }
}

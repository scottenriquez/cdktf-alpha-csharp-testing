using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormat), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters[]? MappingParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormat), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mapping_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mappingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters[]? MappingParameters
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters[]?>();
            }
        }
    }
}

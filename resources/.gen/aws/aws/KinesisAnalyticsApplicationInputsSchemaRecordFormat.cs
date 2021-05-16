using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormat : aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters[]? MappingParameters
        {
            get;
            set;
        }
    }
}

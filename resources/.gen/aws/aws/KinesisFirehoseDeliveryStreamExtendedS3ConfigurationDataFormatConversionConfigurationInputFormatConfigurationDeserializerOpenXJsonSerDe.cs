using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializerOpenXJsonSerDe
    {
        [JsiiOptional]
        [JsiiProperty(name: "caseInsensitive", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? CaseInsensitive
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnToJsonKeyMappings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? ColumnToJsonKeyMappings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "convertDotsInJsonKeysToUnderscores", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ConvertDotsInJsonKeysToUnderscores
        {
            get;
            set;
        }
    }
}

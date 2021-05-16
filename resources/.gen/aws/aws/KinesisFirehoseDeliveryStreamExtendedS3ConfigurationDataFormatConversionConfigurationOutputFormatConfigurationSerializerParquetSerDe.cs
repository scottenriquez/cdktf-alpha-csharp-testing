using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
    {
        [JsiiOptional]
        [JsiiProperty(name: "blockSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BlockSizeBytes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Compression
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableDictionaryCompression", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableDictionaryCompression
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPaddingBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxPaddingBytes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pageSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PageSizeBytes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "writerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WriterVersion
        {
            get;
            set;
        }
    }
}

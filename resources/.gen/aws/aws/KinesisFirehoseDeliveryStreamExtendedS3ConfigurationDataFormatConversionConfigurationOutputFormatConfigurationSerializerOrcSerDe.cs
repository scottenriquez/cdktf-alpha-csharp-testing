using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe
    {
        [JsiiOptional]
        [JsiiProperty(name: "blockSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BlockSizeBytes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bloomFilterColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? BloomFilterColumns
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bloomFilterFalsePositiveProbability", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BloomFilterFalsePositiveProbability
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
        [JsiiProperty(name: "dictionaryKeyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DictionaryKeyThreshold
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enablePadding", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnablePadding
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FormatVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "paddingTolerance", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PaddingTolerance
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rowIndexStride", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RowIndexStride
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stripeSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? StripeSizeBytes
        {
            get;
            set;
        }
    }
}

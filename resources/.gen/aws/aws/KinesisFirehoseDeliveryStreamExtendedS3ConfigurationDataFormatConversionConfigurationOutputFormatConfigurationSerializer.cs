using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer
    {
        /// <summary>orc_ser_de block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orcSerDe", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe[]? OrcSerDe
        {
            get;
            set;
        }

        /// <summary>parquet_ser_de block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parquetSerDe", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe[]? ParquetSerDe
        {
            get;
            set;
        }
    }
}

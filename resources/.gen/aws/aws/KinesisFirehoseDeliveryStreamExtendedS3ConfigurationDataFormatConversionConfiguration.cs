using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration : aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration
    {
        /// <summary>input_format_configuration block.</summary>
        [JsiiProperty(name: "inputFormatConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration[] InputFormatConfiguration
        {
            get;
            set;
        }

        /// <summary>output_format_configuration block.</summary>
        [JsiiProperty(name: "outputFormatConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration[] OutputFormatConfiguration
        {
            get;
            set;
        }

        /// <summary>schema_configuration block.</summary>
        [JsiiProperty(name: "schemaConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration[] SchemaConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }
    }
}

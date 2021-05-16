using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
    {
        [JsiiProperty(name: "blockSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockSizeBytes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Compression
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableDictionaryCompression", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableDictionaryCompression
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxPaddingBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPaddingBytes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "pageSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PageSizeBytes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "writerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WriterVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "blockSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockSizeBytes
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Compression
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableDictionaryCompression", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableDictionaryCompression
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxPaddingBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPaddingBytes
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "pageSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PageSizeBytes
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "writerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WriterVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe
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

        [JsiiProperty(name: "bloomFilterColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BloomFilterColumns
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "bloomFilterFalsePositiveProbability", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BloomFilterFalsePositiveProbability
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

        [JsiiProperty(name: "dictionaryKeyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DictionaryKeyThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enablePadding", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnablePadding
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "formatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FormatVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "paddingTolerance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PaddingTolerance
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rowIndexStride", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RowIndexStride
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "stripeSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StripeSizeBytes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe), fullyQualifiedName: "aws.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe
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
            [JsiiProperty(name: "bloomFilterColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BloomFilterColumns
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "bloomFilterFalsePositiveProbability", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BloomFilterFalsePositiveProbability
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
            [JsiiProperty(name: "dictionaryKeyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DictionaryKeyThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enablePadding", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnablePadding
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "formatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FormatVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "paddingTolerance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PaddingTolerance
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rowIndexStride", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RowIndexStride
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "stripeSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StripeSizeBytes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

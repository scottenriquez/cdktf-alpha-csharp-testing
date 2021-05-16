using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationInputs")]
    public class KinesisAnalyticsApplicationInputs : aws.IKinesisAnalyticsApplicationInputs
    {
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NamePrefix
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchema\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsSchema[] Schema
        {
            get;
            set;
        }

        /// <summary>kinesis_firehose block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsKinesisFirehose\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsKinesisFirehose[]? KinesisFirehose
        {
            get;
            set;
        }

        /// <summary>kinesis_stream block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsKinesisStream\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsKinesisStream[]? KinesisStream
        {
            get;
            set;
        }

        /// <summary>parallelism block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelism", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsParallelism\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsParallelism[]? Parallelism
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationInputsProcessingConfiguration[]? ProcessingConfiguration
        {
            get;
            set;
        }
    }
}

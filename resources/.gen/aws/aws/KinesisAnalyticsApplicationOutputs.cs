using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisAnalyticsApplicationOutputs")]
    public class KinesisAnalyticsApplicationOutputs : aws.IKinesisAnalyticsApplicationOutputs
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsSchema\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IKinesisAnalyticsApplicationOutputsSchema[] Schema
        {
            get;
            set;
        }

        /// <summary>kinesis_firehose block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsKinesisFirehose\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationOutputsKinesisFirehose[]? KinesisFirehose
        {
            get;
            set;
        }

        /// <summary>kinesis_stream block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsKinesisStream\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationOutputsKinesisStream[]? KinesisStream
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsLambda\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKinesisAnalyticsApplicationOutputsLambda[]? Lambda
        {
            get;
            set;
        }
    }
}

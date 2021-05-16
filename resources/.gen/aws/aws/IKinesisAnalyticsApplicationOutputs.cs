using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationOutputs), fullyQualifiedName: "aws.KinesisAnalyticsApplicationOutputs")]
    public interface IKinesisAnalyticsApplicationOutputs
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsSchema\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationOutputsSchema[] Schema
        {
            get;
        }

        /// <summary>kinesis_firehose block.</summary>
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsKinesisFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationOutputsKinesisFirehose[]? KinesisFirehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_stream block.</summary>
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsKinesisStream\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationOutputsKinesisStream[]? KinesisStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsLambda\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationOutputsLambda[]? Lambda
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationOutputs), fullyQualifiedName: "aws.KinesisAnalyticsApplicationOutputs")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationOutputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema block.</summary>
            [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsSchema\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationOutputsSchema[] Schema
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationOutputsSchema[]>()!;
            }

            /// <summary>kinesis_firehose block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsKinesisFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationOutputsKinesisFirehose[]? KinesisFirehose
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationOutputsKinesisFirehose[]?>();
            }

            /// <summary>kinesis_stream block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsKinesisStream\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationOutputsKinesisStream[]? KinesisStream
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationOutputsKinesisStream[]?>();
            }

            /// <summary>lambda block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationOutputsLambda\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationOutputsLambda[]? Lambda
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationOutputsLambda[]?>();
            }
        }
    }
}

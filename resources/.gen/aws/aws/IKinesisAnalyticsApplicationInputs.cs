using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputs), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputs")]
    public interface IKinesisAnalyticsApplicationInputs
    {
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        string NamePrefix
        {
            get;
        }

        /// <summary>schema block.</summary>
        [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchema\"},\"kind\":\"array\"}}")]
        aws.IKinesisAnalyticsApplicationInputsSchema[] Schema
        {
            get;
        }

        /// <summary>kinesis_firehose block.</summary>
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsKinesisFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsKinesisFirehose[]? KinesisFirehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_stream block.</summary>
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsKinesisStream\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsKinesisStream[]? KinesisStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>parallelism block.</summary>
        [JsiiProperty(name: "parallelism", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsParallelism\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsParallelism[]? Parallelism
        {
            get
            {
                return null;
            }
        }

        /// <summary>processing_configuration block.</summary>
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IKinesisAnalyticsApplicationInputsProcessingConfiguration[]? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputs), fullyQualifiedName: "aws.KinesisAnalyticsApplicationInputs")]
        internal sealed class _Proxy : DeputyBase, aws.IKinesisAnalyticsApplicationInputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string NamePrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema block.</summary>
            [JsiiProperty(name: "schema", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsSchema\"},\"kind\":\"array\"}}")]
            public aws.IKinesisAnalyticsApplicationInputsSchema[] Schema
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsSchema[]>()!;
            }

            /// <summary>kinesis_firehose block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsKinesisFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsKinesisFirehose[]? KinesisFirehose
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsKinesisFirehose[]?>();
            }

            /// <summary>kinesis_stream block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStream", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsKinesisStream\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsKinesisStream[]? KinesisStream
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsKinesisStream[]?>();
            }

            /// <summary>parallelism block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelism", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsParallelism\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsParallelism[]? Parallelism
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsParallelism[]?>();
            }

            /// <summary>processing_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KinesisAnalyticsApplicationInputsProcessingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IKinesisAnalyticsApplicationInputsProcessingConfiguration[]? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.IKinesisAnalyticsApplicationInputsProcessingConfiguration[]?>();
            }
        }
    }
}

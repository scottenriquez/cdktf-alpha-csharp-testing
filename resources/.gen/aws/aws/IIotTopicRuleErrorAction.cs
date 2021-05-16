using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorAction), fullyQualifiedName: "aws.IotTopicRuleErrorAction")]
    public interface IIotTopicRuleErrorAction
    {
        /// <summary>cloudwatch_alarm block.</summary>
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionCloudwatchAlarm[]? CloudwatchAlarm
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_metric block.</summary>
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionCloudwatchMetric[]? CloudwatchMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb block.</summary>
        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionDynamodb[]? Dynamodb
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodbv2 block.</summary>
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionDynamodbv2[]? Dynamodbv2
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch block.</summary>
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionElasticsearch[]? Elasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionFirehose[]? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_analytics block.</summary>
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionIotAnalytics[]? IotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_events block.</summary>
        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionIotEvents[]? IotEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis block.</summary>
        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionKinesis[]? Kinesis
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionLambda\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionLambda[]? Lambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>republish block.</summary>
        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionRepublish[]? Republish
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionS3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionS3[]? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns block.</summary>
        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionSns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionSns[]? Sns
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs block.</summary>
        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionSqs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionSqs[]? Sqs
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions block.</summary>
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorActionStepFunctions[]? StepFunctions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorAction), fullyQualifiedName: "aws.IotTopicRuleErrorAction")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_alarm block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionCloudwatchAlarm[]? CloudwatchAlarm
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionCloudwatchAlarm[]?>();
            }

            /// <summary>cloudwatch_metric block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionCloudwatchMetric[]? CloudwatchMetric
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionCloudwatchMetric[]?>();
            }

            /// <summary>dynamodb block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionDynamodb[]? Dynamodb
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionDynamodb[]?>();
            }

            /// <summary>dynamodbv2 block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionDynamodbv2[]? Dynamodbv2
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionDynamodbv2[]?>();
            }

            /// <summary>elasticsearch block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionElasticsearch[]? Elasticsearch
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionElasticsearch[]?>();
            }

            /// <summary>firehose block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionFirehose[]? Firehose
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionFirehose[]?>();
            }

            /// <summary>iot_analytics block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionIotAnalytics[]? IotAnalytics
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionIotAnalytics[]?>();
            }

            /// <summary>iot_events block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionIotEvents[]? IotEvents
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionIotEvents[]?>();
            }

            /// <summary>kinesis block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionKinesis[]? Kinesis
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionKinesis[]?>();
            }

            /// <summary>lambda block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionLambda\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionLambda[]? Lambda
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionLambda[]?>();
            }

            /// <summary>republish block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionRepublish[]? Republish
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionRepublish[]?>();
            }

            /// <summary>s3 block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionS3\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionS3[]? S3
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionS3[]?>();
            }

            /// <summary>sns block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionSns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionSns[]? Sns
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionSns[]?>();
            }

            /// <summary>sqs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionSqs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionSqs[]? Sqs
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionSqs[]?>();
            }

            /// <summary>step_functions block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorActionStepFunctions[]? StepFunctions
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorActionStepFunctions[]?>();
            }
        }
    }
}

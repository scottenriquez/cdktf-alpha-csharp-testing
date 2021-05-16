using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.IotTopicRuleErrorAction")]
    public class IotTopicRuleErrorAction : aws.IIotTopicRuleErrorAction
    {
        /// <summary>cloudwatch_alarm block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionCloudwatchAlarm[]? CloudwatchAlarm
        {
            get;
            set;
        }

        /// <summary>cloudwatch_metric block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionCloudwatchMetric[]? CloudwatchMetric
        {
            get;
            set;
        }

        /// <summary>dynamodb block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodb\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionDynamodb[]? Dynamodb
        {
            get;
            set;
        }

        /// <summary>dynamodbv2 block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionDynamodbv2[]? Dynamodbv2
        {
            get;
            set;
        }

        /// <summary>elasticsearch block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionElasticsearch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionElasticsearch[]? Elasticsearch
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionFirehose\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionFirehose[]? Firehose
        {
            get;
            set;
        }

        /// <summary>iot_analytics block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionIotAnalytics[]? IotAnalytics
        {
            get;
            set;
        }

        /// <summary>iot_events block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionIotEvents\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionIotEvents[]? IotEvents
        {
            get;
            set;
        }

        /// <summary>kinesis block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionKinesis\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionKinesis[]? Kinesis
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionLambda\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionLambda[]? Lambda
        {
            get;
            set;
        }

        /// <summary>republish block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionRepublish\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionRepublish[]? Republish
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionS3\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionS3[]? S3
        {
            get;
            set;
        }

        /// <summary>sns block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionSns\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionSns[]? Sns
        {
            get;
            set;
        }

        /// <summary>sqs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionSqs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionSqs[]? Sqs
        {
            get;
            set;
        }

        /// <summary>step_functions block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorActionStepFunctions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorActionStepFunctions[]? StepFunctions
        {
            get;
            set;
        }
    }
}

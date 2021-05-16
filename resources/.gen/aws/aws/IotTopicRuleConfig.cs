using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleConfig")]
    public class IotTopicRuleConfig : aws.IIotTopicRuleConfig
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Sql
        {
            get;
            set;
        }

        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SqlVersion
        {
            get;
            set;
        }

        /// <summary>cloudwatch_alarm block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarm
        {
            get;
            set;
        }

        /// <summary>cloudwatch_metric block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetric
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>dynamodb block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleDynamodb[]? Dynamodb
        {
            get;
            set;
        }

        /// <summary>dynamodbv2 block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleDynamodbv2[]? Dynamodbv2
        {
            get;
            set;
        }

        /// <summary>elasticsearch block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleElasticsearch[]? Elasticsearch
        {
            get;
            set;
        }

        /// <summary>error_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleErrorAction[]? ErrorAction
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleFirehose[]? Firehose
        {
            get;
            set;
        }

        /// <summary>iot_analytics block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleIotAnalytics[]? IotAnalytics
        {
            get;
            set;
        }

        /// <summary>iot_events block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleIotEvents[]? IotEvents
        {
            get;
            set;
        }

        /// <summary>kinesis block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleKinesis[]? Kinesis
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleLambda[]? Lambda
        {
            get;
            set;
        }

        /// <summary>republish block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleRepublish[]? Republish
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleS3[]? S3
        {
            get;
            set;
        }

        /// <summary>sns block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleSns[]? Sns
        {
            get;
            set;
        }

        /// <summary>sqs block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleSqs[]? Sqs
        {
            get;
            set;
        }

        /// <summary>step_functions block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IIotTopicRuleStepFunctions[]? StepFunctions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}

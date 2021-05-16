using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleConfig), fullyQualifiedName: "aws.IotTopicRuleConfig")]
    public interface IIotTopicRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
        string Sql
        {
            get;
        }

        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SqlVersion
        {
            get;
        }

        /// <summary>cloudwatch_alarm block.</summary>
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarm
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_metric block.</summary>
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetric
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb block.</summary>
        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleDynamodb[]? Dynamodb
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodbv2 block.</summary>
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleDynamodbv2[]? Dynamodbv2
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch block.</summary>
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleElasticsearch[]? Elasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>error_action block.</summary>
        [JsiiProperty(name: "errorAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleErrorAction[]? ErrorAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleFirehose[]? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_analytics block.</summary>
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleIotAnalytics[]? IotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_events block.</summary>
        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleIotEvents[]? IotEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis block.</summary>
        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleKinesis[]? Kinesis
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleLambda[]? Lambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>republish block.</summary>
        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleRepublish[]? Republish
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleS3[]? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns block.</summary>
        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleSns[]? Sns
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs block.</summary>
        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleSqs[]? Sqs
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions block.</summary>
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IIotTopicRuleStepFunctions[]? StepFunctions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleConfig), fullyQualifiedName: "aws.IotTopicRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
            public string Sql
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_alarm block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarm
            {
                get => GetInstanceProperty<aws.IIotTopicRuleCloudwatchAlarm[]?>();
            }

            /// <summary>cloudwatch_metric block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetric
            {
                get => GetInstanceProperty<aws.IIotTopicRuleCloudwatchMetric[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamodb block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleDynamodb[]? Dynamodb
            {
                get => GetInstanceProperty<aws.IIotTopicRuleDynamodb[]?>();
            }

            /// <summary>dynamodbv2 block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleDynamodbv2[]? Dynamodbv2
            {
                get => GetInstanceProperty<aws.IIotTopicRuleDynamodbv2[]?>();
            }

            /// <summary>elasticsearch block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleElasticsearch[]? Elasticsearch
            {
                get => GetInstanceProperty<aws.IIotTopicRuleElasticsearch[]?>();
            }

            /// <summary>error_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleErrorAction[]? ErrorAction
            {
                get => GetInstanceProperty<aws.IIotTopicRuleErrorAction[]?>();
            }

            /// <summary>firehose block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleFirehose[]? Firehose
            {
                get => GetInstanceProperty<aws.IIotTopicRuleFirehose[]?>();
            }

            /// <summary>iot_analytics block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleIotAnalytics[]? IotAnalytics
            {
                get => GetInstanceProperty<aws.IIotTopicRuleIotAnalytics[]?>();
            }

            /// <summary>iot_events block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleIotEvents[]? IotEvents
            {
                get => GetInstanceProperty<aws.IIotTopicRuleIotEvents[]?>();
            }

            /// <summary>kinesis block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleKinesis[]? Kinesis
            {
                get => GetInstanceProperty<aws.IIotTopicRuleKinesis[]?>();
            }

            /// <summary>lambda block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleLambda[]? Lambda
            {
                get => GetInstanceProperty<aws.IIotTopicRuleLambda[]?>();
            }

            /// <summary>republish block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleRepublish[]? Republish
            {
                get => GetInstanceProperty<aws.IIotTopicRuleRepublish[]?>();
            }

            /// <summary>s3 block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleS3[]? S3
            {
                get => GetInstanceProperty<aws.IIotTopicRuleS3[]?>();
            }

            /// <summary>sns block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleSns[]? Sns
            {
                get => GetInstanceProperty<aws.IIotTopicRuleSns[]?>();
            }

            /// <summary>sqs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleSqs[]? Sqs
            {
                get => GetInstanceProperty<aws.IIotTopicRuleSqs[]?>();
            }

            /// <summary>step_functions block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IIotTopicRuleStepFunctions[]? StepFunctions
            {
                get => GetInstanceProperty<aws.IIotTopicRuleStepFunctions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}

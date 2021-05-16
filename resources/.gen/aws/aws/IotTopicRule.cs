using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.IotTopicRule), fullyQualifiedName: "aws.IotTopicRule", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.IotTopicRuleConfig\"}}]")]
    public class IotTopicRule : HashiCorp.Cdktf.TerraformResource
    {
        public IotTopicRule(Constructs.Construct scope, string id, aws.IIotTopicRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCloudwatchAlarm")]
        public virtual void ResetCloudwatchAlarm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchMetric")]
        public virtual void ResetCloudwatchMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodb")]
        public virtual void ResetDynamodb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbv2")]
        public virtual void ResetDynamodbv2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearch")]
        public virtual void ResetElasticsearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorAction")]
        public virtual void ResetErrorAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotAnalytics")]
        public virtual void ResetIotAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotEvents")]
        public virtual void ResetIotEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesis")]
        public virtual void ResetKinesis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambda")]
        public virtual void ResetLambda()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepublish")]
        public virtual void ResetRepublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSns")]
        public virtual void ResetSns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqs")]
        public virtual void ResetSqs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctions")]
        public virtual void ResetStepFunctions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabledInput", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnabledInput
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlVersionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlVersionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarmInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarmInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleCloudwatchAlarm[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetricInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetricInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleCloudwatchMetric[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleDynamodb[]? DynamodbInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleDynamodb[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2Input", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleDynamodbv2[]? Dynamodbv2Input
        {
            get => GetInstanceProperty<aws.IIotTopicRuleDynamodbv2[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleElasticsearch[]? ElasticsearchInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleElasticsearch[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleErrorAction[]? ErrorActionInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleErrorAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleFirehose[]? FirehoseInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleFirehose[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotAnalyticsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleIotAnalytics[]? IotAnalyticsInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleIotAnalytics[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleIotEvents[]? IotEventsInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleIotEvents[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleKinesis[]? KinesisInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleKinesis[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleLambda[]? LambdaInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleLambda[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "republishInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleRepublish[]? RepublishInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleRepublish[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleS3[]? S3Input
        {
            get => GetInstanceProperty<aws.IIotTopicRuleS3[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleSns[]? SnsInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleSns[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleSqs[]? SqsInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleSqs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IIotTopicRuleStepFunctions[]? StepFunctionsInput
        {
            get => GetInstanceProperty<aws.IIotTopicRuleStepFunctions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleCloudwatchAlarm[] CloudwatchAlarm
        {
            get => GetInstanceProperty<aws.IIotTopicRuleCloudwatchAlarm[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleCloudwatchMetric[] CloudwatchMetric
        {
            get => GetInstanceProperty<aws.IIotTopicRuleCloudwatchMetric[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleDynamodb[] Dynamodb
        {
            get => GetInstanceProperty<aws.IIotTopicRuleDynamodb[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleDynamodbv2[] Dynamodbv2
        {
            get => GetInstanceProperty<aws.IIotTopicRuleDynamodbv2[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleElasticsearch[] Elasticsearch
        {
            get => GetInstanceProperty<aws.IIotTopicRuleElasticsearch[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "errorAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleErrorAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleErrorAction[] ErrorAction
        {
            get => GetInstanceProperty<aws.IIotTopicRuleErrorAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleFirehose\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleFirehose[] Firehose
        {
            get => GetInstanceProperty<aws.IIotTopicRuleFirehose[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleIotAnalytics[] IotAnalytics
        {
            get => GetInstanceProperty<aws.IIotTopicRuleIotAnalytics[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleIotEvents[] IotEvents
        {
            get => GetInstanceProperty<aws.IIotTopicRuleIotEvents[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleKinesis\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleKinesis[] Kinesis
        {
            get => GetInstanceProperty<aws.IIotTopicRuleKinesis[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleLambda\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleLambda[] Lambda
        {
            get => GetInstanceProperty<aws.IIotTopicRuleLambda[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleRepublish\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleRepublish[] Republish
        {
            get => GetInstanceProperty<aws.IIotTopicRuleRepublish[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleS3\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleS3[] S3
        {
            get => GetInstanceProperty<aws.IIotTopicRuleS3[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSns\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleSns[] Sns
        {
            get => GetInstanceProperty<aws.IIotTopicRuleSns[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sql
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleSqs\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleSqs[] Sqs
        {
            get => GetInstanceProperty<aws.IIotTopicRuleSqs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}")]
        public virtual aws.IIotTopicRuleStepFunctions[] StepFunctions
        {
            get => GetInstanceProperty<aws.IIotTopicRuleStepFunctions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

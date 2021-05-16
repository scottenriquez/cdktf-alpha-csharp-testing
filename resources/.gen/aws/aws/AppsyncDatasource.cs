using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AppsyncDatasource), fullyQualifiedName: "aws.AppsyncDatasource", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AppsyncDatasourceConfig\"}}]")]
    public class AppsyncDatasource : HashiCorp.Cdktf.TerraformResource
    {
        public AppsyncDatasource(Constructs.Construct scope, string id, aws.IAppsyncDatasourceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbConfig")]
        public virtual void ResetDynamodbConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchConfig")]
        public virtual void ResetElasticsearchConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpConfig")]
        public virtual void ResetHttpConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRoleArn")]
        public virtual void ResetServiceRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceDynamodbConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncDatasourceDynamodbConfig[]? DynamodbConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceDynamodbConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceElasticsearchConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncDatasourceElasticsearchConfig[]? ElasticsearchConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceElasticsearchConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceHttpConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncDatasourceHttpConfig[]? HttpConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceHttpConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncDatasourceLambdaConfig[]? LambdaConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceLambdaConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceDynamodbConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncDatasourceDynamodbConfig[] DynamodbConfig
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceDynamodbConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceElasticsearchConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncDatasourceElasticsearchConfig[] ElasticsearchConfig
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceElasticsearchConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceHttpConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncDatasourceHttpConfig[] HttpConfig
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceHttpConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceLambdaConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncDatasourceLambdaConfig[] LambdaConfig
        {
            get => GetInstanceProperty<aws.IAppsyncDatasourceLambdaConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

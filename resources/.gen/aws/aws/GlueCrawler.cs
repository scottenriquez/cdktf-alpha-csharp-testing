using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GlueCrawler), fullyQualifiedName: "aws.GlueCrawler", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GlueCrawlerConfig\"}}]")]
    public class GlueCrawler : HashiCorp.Cdktf.TerraformResource
    {
        public GlueCrawler(Constructs.Construct scope, string id, aws.IGlueCrawlerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCrawler(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCrawler(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCatalogTarget")]
        public virtual void ResetCatalogTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClassifiers")]
        public virtual void ResetClassifiers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbTarget")]
        public virtual void ResetDynamodbTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJdbcTarget")]
        public virtual void ResetJdbcTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Target")]
        public virtual void ResetS3Target()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaChangePolicy")]
        public virtual void ResetSchemaChangePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablePrefix")]
        public virtual void ResetTablePrefix()
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

        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseNameInput
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

        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCrawlerCatalogTarget[]? CatalogTargetInput
        {
            get => GetInstanceProperty<aws.IGlueCrawlerCatalogTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "classifiersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClassifiersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCrawlerDynamodbTarget[]? DynamodbTargetInput
        {
            get => GetInstanceProperty<aws.IGlueCrawlerDynamodbTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jdbcTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCrawlerJdbcTarget[]? JdbcTargetInput
        {
            get => GetInstanceProperty<aws.IGlueCrawlerJdbcTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3TargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerS3Target\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCrawlerS3Target[]? S3TargetInput
        {
            get => GetInstanceProperty<aws.IGlueCrawlerS3Target[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaChangePolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerSchemaChangePolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCrawlerSchemaChangePolicy[]? SchemaChangePolicyInput
        {
            get => GetInstanceProperty<aws.IGlueCrawlerSchemaChangePolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TablePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "catalogTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCrawlerCatalogTarget[] CatalogTarget
        {
            get => GetInstanceProperty<aws.IGlueCrawlerCatalogTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Classifiers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
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

        [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCrawlerDynamodbTarget[] DynamodbTarget
        {
            get => GetInstanceProperty<aws.IGlueCrawlerDynamodbTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jdbcTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCrawlerJdbcTarget[] JdbcTarget
        {
            get => GetInstanceProperty<aws.IGlueCrawlerJdbcTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Target", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerS3Target\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCrawlerS3Target[] S3Target
        {
            get => GetInstanceProperty<aws.IGlueCrawlerS3Target[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerSchemaChangePolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCrawlerSchemaChangePolicy[] SchemaChangePolicy
        {
            get => GetInstanceProperty<aws.IGlueCrawlerSchemaChangePolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TablePrefix
        {
            get => GetInstanceProperty<string>()!;
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DmsEndpoint), fullyQualifiedName: "aws.DmsEndpoint", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DmsEndpointConfig\"}}]")]
    public class DmsEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        public DmsEndpoint(Constructs.Construct scope, string id, aws.IDmsEndpointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseName")]
        public virtual void ResetDatabaseName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchSettings")]
        public virtual void ResetElasticsearchSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtraConnectionAttributes")]
        public virtual void ResetExtraConnectionAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafkaSettings")]
        public virtual void ResetKafkaSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisSettings")]
        public virtual void ResetKinesisSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongodbSettings")]
        public virtual void ResetMongodbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Settings")]
        public virtual void ResetS3Settings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerName")]
        public virtual void ResetServerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccessRole")]
        public virtual void ResetServiceAccessRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslMode")]
        public virtual void ResetSslMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsername")]
        public virtual void ResetUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "endpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointElasticsearchSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDmsEndpointElasticsearchSettings[]? ElasticsearchSettingsInput
        {
            get => GetInstanceProperty<aws.IDmsEndpointElasticsearchSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extraConnectionAttributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtraConnectionAttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKafkaSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDmsEndpointKafkaSettings[]? KafkaSettingsInput
        {
            get => GetInstanceProperty<aws.IDmsEndpointKafkaSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKinesisSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDmsEndpointKinesisSettings[]? KinesisSettingsInput
        {
            get => GetInstanceProperty<aws.IDmsEndpointKinesisSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongodbSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointMongodbSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDmsEndpointMongodbSettings[]? MongodbSettingsInput
        {
            get => GetInstanceProperty<aws.IDmsEndpointMongodbSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3SettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointS3Settings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDmsEndpointS3Settings[]? S3SettingsInput
        {
            get => GetInstanceProperty<aws.IDmsEndpointS3Settings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccessRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
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

        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointElasticsearchSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IDmsEndpointElasticsearchSettings[] ElasticsearchSettings
        {
            get => GetInstanceProperty<aws.IDmsEndpointElasticsearchSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtraConnectionAttributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKafkaSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IDmsEndpointKafkaSettings[] KafkaSettings
        {
            get => GetInstanceProperty<aws.IDmsEndpointKafkaSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKinesisSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IDmsEndpointKinesisSettings[] KinesisSettings
        {
            get => GetInstanceProperty<aws.IDmsEndpointKinesisSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointMongodbSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IDmsEndpointMongodbSettings[] MongodbSettings
        {
            get => GetInstanceProperty<aws.IDmsEndpointMongodbSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointS3Settings\"},\"kind\":\"array\"}}")]
        public virtual aws.IDmsEndpointS3Settings[] S3Settings
        {
            get => GetInstanceProperty<aws.IDmsEndpointS3Settings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
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

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

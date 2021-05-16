using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointConfig), fullyQualifiedName: "aws.DmsEndpointConfig")]
    public interface IDmsEndpointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointId
        {
            get;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointType
        {
            get;
        }

        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        string EngineName
        {
            get;
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_settings block.</summary>
        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointElasticsearchSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDmsEndpointElasticsearchSettings[]? ElasticsearchSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExtraConnectionAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>kafka_settings block.</summary>
        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKafkaSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDmsEndpointKafkaSettings[]? KafkaSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_settings block.</summary>
        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKinesisSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDmsEndpointKinesisSettings[]? KinesisSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>mongodb_settings block.</summary>
        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointMongodbSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDmsEndpointMongodbSettings[]? MongodbSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_settings block.</summary>
        [JsiiProperty(name: "s3Settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointS3Settings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IDmsEndpointS3Settings[]? S3Settings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccessRole
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslMode
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

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointConfig), fullyQualifiedName: "aws.DmsEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDmsEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
            public string EngineName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>elasticsearch_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointElasticsearchSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDmsEndpointElasticsearchSettings[]? ElasticsearchSettings
            {
                get => GetInstanceProperty<aws.IDmsEndpointElasticsearchSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExtraConnectionAttributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kafka_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kafkaSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKafkaSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDmsEndpointKafkaSettings[]? KafkaSettings
            {
                get => GetInstanceProperty<aws.IDmsEndpointKafkaSettings[]?>();
            }

            /// <summary>kinesis_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointKinesisSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDmsEndpointKinesisSettings[]? KinesisSettings
            {
                get => GetInstanceProperty<aws.IDmsEndpointKinesisSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mongodb_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mongodbSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointMongodbSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDmsEndpointMongodbSettings[]? MongodbSettings
            {
                get => GetInstanceProperty<aws.IDmsEndpointMongodbSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>s3_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DmsEndpointS3Settings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IDmsEndpointS3Settings[]? S3Settings
            {
                get => GetInstanceProperty<aws.IDmsEndpointS3Settings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccessRole
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
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

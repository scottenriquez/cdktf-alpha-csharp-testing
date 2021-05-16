using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceConfig), fullyQualifiedName: "aws.AppsyncDatasourceConfig")]
    public interface IAppsyncDatasourceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
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

        /// <summary>dynamodb_config block.</summary>
        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceDynamodbConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncDatasourceDynamodbConfig[]? DynamodbConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_config block.</summary>
        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceElasticsearchConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncDatasourceElasticsearchConfig[]? ElasticsearchConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_config block.</summary>
        [JsiiProperty(name: "httpConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceHttpConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncDatasourceHttpConfig[]? HttpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_config block.</summary>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncDatasourceLambdaConfig[]? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceConfig), fullyQualifiedName: "aws.AppsyncDatasourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncDatasourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamodb_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceDynamodbConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncDatasourceDynamodbConfig[]? DynamodbConfig
            {
                get => GetInstanceProperty<aws.IAppsyncDatasourceDynamodbConfig[]?>();
            }

            /// <summary>elasticsearch_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceElasticsearchConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncDatasourceElasticsearchConfig[]? ElasticsearchConfig
            {
                get => GetInstanceProperty<aws.IAppsyncDatasourceElasticsearchConfig[]?>();
            }

            /// <summary>http_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceHttpConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncDatasourceHttpConfig[]? HttpConfig
            {
                get => GetInstanceProperty<aws.IAppsyncDatasourceHttpConfig[]?>();
            }

            /// <summary>lambda_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncDatasourceLambdaConfig[]? LambdaConfig
            {
                get => GetInstanceProperty<aws.IAppsyncDatasourceLambdaConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRoleArn
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerConfig), fullyQualifiedName: "aws.GlueCrawlerConfig")]
    public interface IGlueCrawlerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>catalog_target block.</summary>
        [JsiiProperty(name: "catalogTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCrawlerCatalogTarget[]? CatalogTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Classifiers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Configuration
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

        /// <summary>dynamodb_target block.</summary>
        [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCrawlerDynamodbTarget[]? DynamodbTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>jdbc_target block.</summary>
        [JsiiProperty(name: "jdbcTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCrawlerJdbcTarget[]? JdbcTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_target block.</summary>
        [JsiiProperty(name: "s3Target", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerS3Target\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCrawlerS3Target[]? S3Target
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema_change_policy block.</summary>
        [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerSchemaChangePolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueCrawlerSchemaChangePolicy[]? SchemaChangePolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TablePrefix
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

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerConfig), fullyQualifiedName: "aws.GlueCrawlerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueCrawlerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>catalog_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCrawlerCatalogTarget[]? CatalogTarget
            {
                get => GetInstanceProperty<aws.IGlueCrawlerCatalogTarget[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Classifiers
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Configuration
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamodb_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCrawlerDynamodbTarget[]? DynamodbTarget
            {
                get => GetInstanceProperty<aws.IGlueCrawlerDynamodbTarget[]?>();
            }

            /// <summary>jdbc_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jdbcTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCrawlerJdbcTarget[]? JdbcTarget
            {
                get => GetInstanceProperty<aws.IGlueCrawlerJdbcTarget[]?>();
            }

            /// <summary>s3_target block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Target", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerS3Target\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCrawlerS3Target[]? S3Target
            {
                get => GetInstanceProperty<aws.IGlueCrawlerS3Target[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schedule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>schema_change_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerSchemaChangePolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueCrawlerSchemaChangePolicy[]? SchemaChangePolicy
            {
                get => GetInstanceProperty<aws.IGlueCrawlerSchemaChangePolicy[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TablePrefix
            {
                get => GetInstanceProperty<string?>();
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

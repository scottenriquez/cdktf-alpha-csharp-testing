using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueCrawlerConfig")]
    public class GlueCrawlerConfig : aws.IGlueCrawlerConfig
    {
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DatabaseName
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

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Role
        {
            get;
            set;
        }

        /// <summary>catalog_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCrawlerCatalogTarget[]? CatalogTarget
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Classifiers
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Configuration
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

        /// <summary>dynamodb_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCrawlerDynamodbTarget[]? DynamodbTarget
        {
            get;
            set;
        }

        /// <summary>jdbc_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jdbcTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCrawlerJdbcTarget[]? JdbcTarget
        {
            get;
            set;
        }

        /// <summary>s3_target block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Target", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerS3Target\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCrawlerS3Target[]? S3Target
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Schedule
        {
            get;
            set;
        }

        /// <summary>schema_change_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCrawlerSchemaChangePolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGlueCrawlerSchemaChangePolicy[]? SchemaChangePolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TablePrefix
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncDatasourceConfig")]
    public class AppsyncDatasourceConfig : aws.IAppsyncDatasourceConfig
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
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

        /// <summary>dynamodb_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceDynamodbConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncDatasourceDynamodbConfig[]? DynamodbConfig
        {
            get;
            set;
        }

        /// <summary>elasticsearch_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceElasticsearchConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncDatasourceElasticsearchConfig[]? ElasticsearchConfig
        {
            get;
            set;
        }

        /// <summary>http_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceHttpConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncDatasourceHttpConfig[]? HttpConfig
        {
            get;
            set;
        }

        /// <summary>lambda_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncDatasourceLambdaConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncDatasourceLambdaConfig[]? LambdaConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceRoleArn
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

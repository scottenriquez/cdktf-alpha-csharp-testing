using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncResolverConfig")]
    public class AppsyncResolverConfig : aws.IAppsyncResolverConfig
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApiId
        {
            get;
            set;
        }

        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Field
        {
            get;
            set;
        }

        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RequestTemplate
        {
            get;
            set;
        }

        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ResponseTemplate
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

        /// <summary>caching_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cachingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverCachingConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncResolverCachingConfig[]? CachingConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataSource
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>pipeline_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverPipelineConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppsyncResolverPipelineConfig[]? PipelineConfig
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppsyncResolverConfig), fullyQualifiedName: "aws.AppsyncResolverConfig")]
    public interface IAppsyncResolverConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string RequestTemplate
        {
            get;
        }

        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string ResponseTemplate
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>caching_config block.</summary>
        [JsiiProperty(name: "cachingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverCachingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncResolverCachingConfig[]? CachingConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>pipeline_config block.</summary>
        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverPipelineConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppsyncResolverPipelineConfig[]? PipelineConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverConfig), fullyQualifiedName: "aws.AppsyncResolverConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAppsyncResolverConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string ResponseTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>caching_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cachingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverCachingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncResolverCachingConfig[]? CachingConfig
            {
                get => GetInstanceProperty<aws.IAppsyncResolverCachingConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSource
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>pipeline_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverPipelineConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppsyncResolverPipelineConfig[]? PipelineConfig
            {
                get => GetInstanceProperty<aws.IAppsyncResolverPipelineConfig[]?>();
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

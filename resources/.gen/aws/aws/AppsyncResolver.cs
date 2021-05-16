using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AppsyncResolver), fullyQualifiedName: "aws.AppsyncResolver", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AppsyncResolverConfig\"}}]")]
    public class AppsyncResolver : HashiCorp.Cdktf.TerraformResource
    {
        public AppsyncResolver(Constructs.Construct scope, string id, aws.IAppsyncResolverConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncResolver(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncResolver(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCachingConfig")]
        public virtual void ResetCachingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataSource")]
        public virtual void ResetDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKind")]
        public virtual void ResetKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPipelineConfig")]
        public virtual void ResetPipelineConfig()
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

        [JsiiProperty(name: "fieldInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestTemplateInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestTemplateInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "responseTemplateInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseTemplateInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverCachingConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncResolverCachingConfig[]? CachingConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncResolverCachingConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverPipelineConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncResolverPipelineConfig[]? PipelineConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncResolverPipelineConfig[]?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cachingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverCachingConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncResolverCachingConfig[] CachingConfig
        {
            get => GetInstanceProperty<aws.IAppsyncResolverCachingConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Field
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pipelineConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncResolverPipelineConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncResolverPipelineConfig[] PipelineConfig
        {
            get => GetInstanceProperty<aws.IAppsyncResolverPipelineConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseTemplate
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

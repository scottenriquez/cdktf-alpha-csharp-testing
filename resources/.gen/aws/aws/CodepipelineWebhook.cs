using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CodepipelineWebhook), fullyQualifiedName: "aws.CodepipelineWebhook", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CodepipelineWebhookConfig\"}}]")]
    public class CodepipelineWebhook : HashiCorp.Cdktf.TerraformResource
    {
        public CodepipelineWebhook(Constructs.Construct scope, string id, aws.ICodepipelineWebhookConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineWebhook(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineWebhook(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthenticationConfiguration")]
        public virtual void ResetAuthenticationConfiguration()
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

        [JsiiProperty(name: "authenticationInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodepipelineWebhookFilter[] FilterInput
        {
            get => GetInstanceProperty<aws.ICodepipelineWebhookFilter[]>()!;
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

        [JsiiProperty(name: "targetActionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetActionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetPipelineInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetPipelineInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookAuthenticationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodepipelineWebhookAuthenticationConfiguration[]? AuthenticationConfigurationInput
        {
            get => GetInstanceProperty<aws.ICodepipelineWebhookAuthenticationConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookAuthenticationConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodepipelineWebhookAuthenticationConfiguration[] AuthenticationConfiguration
        {
            get => GetInstanceProperty<aws.ICodepipelineWebhookAuthenticationConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodepipelineWebhookFilter[] Filter
        {
            get => GetInstanceProperty<aws.ICodepipelineWebhookFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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

        [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetPipeline
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

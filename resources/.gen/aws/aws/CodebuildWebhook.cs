using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CodebuildWebhook), fullyQualifiedName: "aws.CodebuildWebhook", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CodebuildWebhookConfig\"}}]")]
    public class CodebuildWebhook : HashiCorp.Cdktf.TerraformResource
    {
        public CodebuildWebhook(Constructs.Construct scope, string id, aws.ICodebuildWebhookConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildWebhook(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildWebhook(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBranchFilter")]
        public virtual void ResetBranchFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterGroup")]
        public virtual void ResetFilterGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payloadUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayloadUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Secret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BranchFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodebuildWebhookFilterGroup[]? FilterGroupInput
        {
            get => GetInstanceProperty<aws.ICodebuildWebhookFilterGroup[]?>();
        }

        [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BranchFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filterGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodebuildWebhookFilterGroup[] FilterGroup
        {
            get => GetInstanceProperty<aws.ICodebuildWebhookFilterGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ConfigConfigurationAggregator), fullyQualifiedName: "aws.ConfigConfigurationAggregator", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ConfigConfigurationAggregatorConfig\"}}]")]
    public class ConfigConfigurationAggregator : HashiCorp.Cdktf.TerraformResource
    {
        public ConfigConfigurationAggregator(Constructs.Construct scope, string id, aws.IConfigConfigurationAggregatorConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationAggregator(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationAggregator(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccountAggregationSource")]
        public virtual void ResetAccountAggregationSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrganizationAggregationSource")]
        public virtual void ResetOrganizationAggregationSource()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "accountAggregationSourceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigurationAggregatorAccountAggregationSource\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IConfigConfigurationAggregatorAccountAggregationSource[]? AccountAggregationSourceInput
        {
            get => GetInstanceProperty<aws.IConfigConfigurationAggregatorAccountAggregationSource[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationAggregationSourceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigurationAggregatorOrganizationAggregationSource\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IConfigConfigurationAggregatorOrganizationAggregationSource[]? OrganizationAggregationSourceInput
        {
            get => GetInstanceProperty<aws.IConfigConfigurationAggregatorOrganizationAggregationSource[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "accountAggregationSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigurationAggregatorAccountAggregationSource\"},\"kind\":\"array\"}}")]
        public virtual aws.IConfigConfigurationAggregatorAccountAggregationSource[] AccountAggregationSource
        {
            get => GetInstanceProperty<aws.IConfigConfigurationAggregatorAccountAggregationSource[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "organizationAggregationSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigurationAggregatorOrganizationAggregationSource\"},\"kind\":\"array\"}}")]
        public virtual aws.IConfigConfigurationAggregatorOrganizationAggregationSource[] OrganizationAggregationSource
        {
            get => GetInstanceProperty<aws.IConfigConfigurationAggregatorOrganizationAggregationSource[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

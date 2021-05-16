using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafWebAcl), fullyQualifiedName: "aws.WafWebAcl", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafWebAclConfig\"}}]")]
    public class WafWebAcl : HashiCorp.Cdktf.TerraformResource
    {
        public WafWebAcl(Constructs.Construct scope, string id, aws.IWafWebAclConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAcl(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRules")]
        public virtual void ResetRules()
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

        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclDefaultAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafWebAclDefaultAction[] DefaultActionInput
        {
            get => GetInstanceProperty<aws.IWafWebAclDefaultAction[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafWebAclLoggingConfiguration[]? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.IWafWebAclLoggingConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclRules\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafWebAclRules[]? RulesInput
        {
            get => GetInstanceProperty<aws.IWafWebAclRules[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclDefaultAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafWebAclDefaultAction[] DefaultAction
        {
            get => GetInstanceProperty<aws.IWafWebAclDefaultAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclLoggingConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafWebAclLoggingConfiguration[] LoggingConfiguration
        {
            get => GetInstanceProperty<aws.IWafWebAclLoggingConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafWebAclRules\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafWebAclRules[] Rules
        {
            get => GetInstanceProperty<aws.IWafWebAclRules[]>()!;
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

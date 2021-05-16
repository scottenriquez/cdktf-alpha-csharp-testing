using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WafregionalWebAcl), fullyQualifiedName: "aws.WafregionalWebAcl", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WafregionalWebAclConfig\"}}]")]
    public class WafregionalWebAcl : HashiCorp.Cdktf.TerraformResource
    {
        public WafregionalWebAcl(Constructs.Construct scope, string id, aws.IWafregionalWebAclConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAcl(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
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

        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclDefaultAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafregionalWebAclDefaultAction[] DefaultActionInput
        {
            get => GetInstanceProperty<aws.IWafregionalWebAclDefaultAction[]>()!;
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
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafregionalWebAclLoggingConfiguration[]? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.IWafregionalWebAclLoggingConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWafregionalWebAclRule[]? RuleInput
        {
            get => GetInstanceProperty<aws.IWafregionalWebAclRule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclDefaultAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafregionalWebAclDefaultAction[] DefaultAction
        {
            get => GetInstanceProperty<aws.IWafregionalWebAclDefaultAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclLoggingConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafregionalWebAclLoggingConfiguration[] LoggingConfiguration
        {
            get => GetInstanceProperty<aws.IWafregionalWebAclLoggingConfiguration[]>()!;
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

        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalWebAclRule\"},\"kind\":\"array\"}}")]
        public virtual aws.IWafregionalWebAclRule[] Rule
        {
            get => GetInstanceProperty<aws.IWafregionalWebAclRule[]>()!;
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

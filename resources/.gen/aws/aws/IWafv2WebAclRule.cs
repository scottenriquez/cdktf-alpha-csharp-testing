using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRule), fullyQualifiedName: "aws.Wafv2WebAclRule")]
    public interface IWafv2WebAclRule
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>statement block.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatement\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleStatement[] Statement
        {
            get;
        }

        /// <summary>visibility_config block.</summary>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleVisibilityConfig\"},\"kind\":\"array\"}}")]
        aws.IWafv2WebAclRuleVisibilityConfig[] VisibilityConfig
        {
            get;
        }

        /// <summary>action block.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleAction[]? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>override_action block.</summary>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleOverrideAction[]? OverrideAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRule), fullyQualifiedName: "aws.Wafv2WebAclRule")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>statement block.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatement\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleStatement[] Statement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatement[]>()!;
            }

            /// <summary>visibility_config block.</summary>
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleVisibilityConfig\"},\"kind\":\"array\"}}")]
            public aws.IWafv2WebAclRuleVisibilityConfig[] VisibilityConfig
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleVisibilityConfig[]>()!;
            }

            /// <summary>action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleAction[]? Action
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleAction[]?>();
            }

            /// <summary>override_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleOverrideAction[]? OverrideAction
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleOverrideAction[]?>();
            }
        }
    }
}

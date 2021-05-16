using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleAction), fullyQualifiedName: "aws.Wafv2WebAclRuleAction")]
    public interface IWafv2WebAclRuleAction
    {
        /// <summary>allow block.</summary>
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionAllow\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleActionAllow[]? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionBlock\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleActionBlock[]? Block
        {
            get
            {
                return null;
            }
        }

        /// <summary>count block.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionCount\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleActionCount[]? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleAction), fullyQualifiedName: "aws.Wafv2WebAclRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionAllow\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleActionAllow[]? Allow
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleActionAllow[]?>();
            }

            /// <summary>block block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionBlock\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleActionBlock[]? Block
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleActionBlock[]?>();
            }

            /// <summary>count block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleActionCount\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleActionCount[]? Count
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleActionCount[]?>();
            }
        }
    }
}

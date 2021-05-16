using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleOverrideAction), fullyQualifiedName: "aws.Wafv2WebAclRuleOverrideAction")]
    public interface IWafv2WebAclRuleOverrideAction
    {
        /// <summary>count block.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideActionCount\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleOverrideActionCount[]? Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>none block.</summary>
        [JsiiProperty(name: "none", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideActionNone\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleOverrideActionNone[]? None
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleOverrideAction), fullyQualifiedName: "aws.Wafv2WebAclRuleOverrideAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleOverrideAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>count block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideActionCount\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleOverrideActionCount[]? Count
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleOverrideActionCount[]?>();
            }

            /// <summary>none block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "none", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleOverrideActionNone\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleOverrideActionNone[]? None
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleOverrideActionNone[]?>();
            }
        }
    }
}

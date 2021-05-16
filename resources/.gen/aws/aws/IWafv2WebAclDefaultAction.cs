using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDefaultAction), fullyQualifiedName: "aws.Wafv2WebAclDefaultAction")]
    public interface IWafv2WebAclDefaultAction
    {
        /// <summary>allow block.</summary>
        [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclDefaultActionAllow\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclDefaultActionAllow[]? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclDefaultActionBlock\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclDefaultActionBlock[]? Block
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDefaultAction), fullyQualifiedName: "aws.Wafv2WebAclDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclDefaultAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclDefaultActionAllow\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclDefaultActionAllow[]? Allow
            {
                get => GetInstanceProperty<aws.IWafv2WebAclDefaultActionAllow[]?>();
            }

            /// <summary>block block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclDefaultActionBlock\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclDefaultActionBlock[]? Block
            {
                get => GetInstanceProperty<aws.IWafv2WebAclDefaultActionBlock[]?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleSource), fullyQualifiedName: "aws.ConfigConfigRuleSource")]
    public interface IConfigConfigRuleSource
    {
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string SourceIdentifier
        {
            get;
        }

        /// <summary>source_detail block.</summary>
        [JsiiProperty(name: "sourceDetail", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IConfigConfigRuleSourceSourceDetail[]? SourceDetail
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleSource), fullyQualifiedName: "aws.ConfigConfigRuleSource")]
        internal sealed class _Proxy : DeputyBase, aws.IConfigConfigRuleSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source_detail block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDetail", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IConfigConfigRuleSourceSourceDetail[]? SourceDetail
            {
                get => GetInstanceProperty<aws.IConfigConfigRuleSourceSourceDetail[]?>();
            }
        }
    }
}

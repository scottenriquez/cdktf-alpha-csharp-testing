using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2RegexPatternSetRegularExpression), fullyQualifiedName: "aws.Wafv2RegexPatternSetRegularExpression")]
    public interface IWafv2RegexPatternSetRegularExpression
    {
        [JsiiProperty(name: "regexString", typeJson: "{\"primitive\":\"string\"}")]
        string RegexString
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RegexPatternSetRegularExpression), fullyQualifiedName: "aws.Wafv2RegexPatternSetRegularExpression")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2RegexPatternSetRegularExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "regexString", typeJson: "{\"primitive\":\"string\"}")]
            public string RegexString
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

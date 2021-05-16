using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch), fullyQualifiedName: "aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch")]
    public interface IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch), fullyQualifiedName: "aws.WafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

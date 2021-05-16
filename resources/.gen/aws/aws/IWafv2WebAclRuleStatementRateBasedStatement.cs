using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatement
    {
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        double Limit
        {
            get;
        }

        [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AggregateKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope_down_statement block.</summary>
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement[]? ScopeDownStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRateBasedStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
            public double Limit
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "aggregateKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AggregateKeyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scope_down_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement[]? ScopeDownStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement[]?>();
            }
        }
    }
}

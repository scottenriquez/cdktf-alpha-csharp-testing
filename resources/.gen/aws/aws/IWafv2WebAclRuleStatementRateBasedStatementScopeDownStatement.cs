using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement
    {
        /// <summary>and_statement block.</summary>
        [JsiiProperty(name: "andStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement[]? AndStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>byte_match_statement block.</summary>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement[]? ByteMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>geo_match_statement block.</summary>
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement[]? GeoMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_set_reference_statement block.</summary>
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement[]? IpSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_statement block.</summary>
        [JsiiProperty(name: "notStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement[]? NotStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>or_statement block.</summary>
        [JsiiProperty(name: "orStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement[]? OrStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>size_constraint_statement block.</summary>
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement[]? SizeConstraintStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqli_match_statement block.</summary>
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement[]? SqliMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_match_statement block.</summary>
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement[]? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "andStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement[]? AndStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement[]?>();
            }

            /// <summary>byte_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement[]? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement[]?>();
            }

            /// <summary>geo_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement[]? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement[]?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement[]? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement[]?>();
            }

            /// <summary>not_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement[]? NotStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement[]?>();
            }

            /// <summary>or_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement[]? OrStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement[]?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement[]?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement[]? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement[]?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement[]? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement[]?>();
            }

            /// <summary>xss_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement[]? XssMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement[]?>();
            }
        }
    }
}

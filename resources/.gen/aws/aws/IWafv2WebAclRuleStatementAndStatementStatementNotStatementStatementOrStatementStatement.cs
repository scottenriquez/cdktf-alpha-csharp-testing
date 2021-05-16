using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement[]? ByteMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>geo_match_statement block.</summary>
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement[]? GeoMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_set_reference_statement block.</summary>
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>size_constraint_statement block.</summary>
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqli_match_statement block.</summary>
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement[]? SqliMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_match_statement block.</summary>
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement[]? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>byte_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement[]? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement[]?>();
            }

            /// <summary>geo_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement[]? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementGeoMatchStatement[]?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementIpSetReferenceStatement[]?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[]?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSizeConstraintStatement[]?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement[]? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementSqliMatchStatement[]?>();
            }

            /// <summary>xss_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement[]? XssMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement[]?>();
            }
        }
    }
}

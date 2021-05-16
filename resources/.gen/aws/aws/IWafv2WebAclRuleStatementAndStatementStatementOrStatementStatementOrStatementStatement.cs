using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatement
    {
        /// <summary>byte_match_statement block.</summary>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement[]? ByteMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>geo_match_statement block.</summary>
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement[]? GeoMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_set_reference_statement block.</summary>
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>size_constraint_statement block.</summary>
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqli_match_statement block.</summary>
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement[]? SqliMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_match_statement block.</summary>
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement[]? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>byte_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement[]? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementByteMatchStatement[]?>();
            }

            /// <summary>geo_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement[]? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementGeoMatchStatement[]?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementIpSetReferenceStatement[]?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement[]?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSizeConstraintStatement[]?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement[]? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementSqliMatchStatement[]?>();
            }

            /// <summary>xss_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement[]? XssMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementOrStatementStatementXssMatchStatement[]?>();
            }
        }
    }
}

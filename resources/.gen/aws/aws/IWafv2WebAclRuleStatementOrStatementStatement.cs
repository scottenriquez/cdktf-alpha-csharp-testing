using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatement")]
    public interface IWafv2WebAclRuleStatementOrStatementStatement
    {
        /// <summary>and_statement block.</summary>
        [JsiiProperty(name: "andStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementAndStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementAndStatement[]? AndStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>byte_match_statement block.</summary>
        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatement[]? ByteMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>geo_match_statement block.</summary>
        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement[]? GeoMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_set_reference_statement block.</summary>
        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_statement block.</summary>
        [JsiiProperty(name: "notStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementNotStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementNotStatement[]? NotStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>or_statement block.</summary>
        [JsiiProperty(name: "orStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatement[]? OrStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_pattern_set_reference_statement block.</summary>
        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>size_constraint_statement block.</summary>
        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqli_match_statement block.</summary>
        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatement[]? SqliMatchStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_match_statement block.</summary>
        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatement[]? XssMatchStatement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatement), fullyQualifiedName: "aws.Wafv2WebAclRuleStatementOrStatementStatement")]
        internal sealed class _Proxy : DeputyBase, aws.IWafv2WebAclRuleStatementOrStatementStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "andStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementAndStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementAndStatement[]? AndStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementAndStatement[]?>();
            }

            /// <summary>byte_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementByteMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatement[]? ByteMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementByteMatchStatement[]?>();
            }

            /// <summary>geo_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement[]? GeoMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement[]?>();
            }

            /// <summary>ip_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementIpSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementIpSetReferenceStatement[]? IpSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementIpSetReferenceStatement[]?>();
            }

            /// <summary>not_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementNotStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementNotStatement[]? NotStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementNotStatement[]?>();
            }

            /// <summary>or_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementOrStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatement[]? OrStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementOrStatement[]?>();
            }

            /// <summary>regex_pattern_set_reference_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementRegexPatternSetReferenceStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementRegexPatternSetReferenceStatement[]? RegexPatternSetReferenceStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementRegexPatternSetReferenceStatement[]?>();
            }

            /// <summary>size_constraint_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatement[]? SizeConstraintStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatement[]?>();
            }

            /// <summary>sqli_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatement[]? SqliMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatement[]?>();
            }

            /// <summary>xss_match_statement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Wafv2WebAclRuleStatementOrStatementStatementXssMatchStatement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatement[]? XssMatchStatement
            {
                get => GetInstanceProperty<aws.IWafv2WebAclRuleStatementOrStatementStatementXssMatchStatement[]?>();
            }
        }
    }
}

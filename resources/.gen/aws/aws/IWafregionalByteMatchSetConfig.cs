using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalByteMatchSetConfig), fullyQualifiedName: "aws.WafregionalByteMatchSetConfig")]
    public interface IWafregionalByteMatchSetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>byte_match_tuple block.</summary>
        [JsiiProperty(name: "byteMatchTuple", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalByteMatchSetByteMatchTuple\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafregionalByteMatchSetByteMatchTuple[]? ByteMatchTuple
        {
            get
            {
                return null;
            }
        }

        /// <summary>byte_match_tuples block.</summary>
        [JsiiProperty(name: "byteMatchTuples", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalByteMatchSetByteMatchTuples\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafregionalByteMatchSetByteMatchTuples[]? ByteMatchTuples
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalByteMatchSetConfig), fullyQualifiedName: "aws.WafregionalByteMatchSetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalByteMatchSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>byte_match_tuple block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchTuple", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalByteMatchSetByteMatchTuple\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafregionalByteMatchSetByteMatchTuple[]? ByteMatchTuple
            {
                get => GetInstanceProperty<aws.IWafregionalByteMatchSetByteMatchTuple[]?>();
            }

            /// <summary>byte_match_tuples block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "byteMatchTuples", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalByteMatchSetByteMatchTuples\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafregionalByteMatchSetByteMatchTuples[]? ByteMatchTuples
            {
                get => GetInstanceProperty<aws.IWafregionalByteMatchSetByteMatchTuples[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}

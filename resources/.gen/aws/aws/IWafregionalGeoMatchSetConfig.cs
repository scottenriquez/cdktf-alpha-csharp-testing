using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWafregionalGeoMatchSetConfig), fullyQualifiedName: "aws.WafregionalGeoMatchSetConfig")]
    public interface IWafregionalGeoMatchSetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>geo_match_constraint block.</summary>
        [JsiiProperty(name: "geoMatchConstraint", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalGeoMatchSetGeoMatchConstraint\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWafregionalGeoMatchSetGeoMatchConstraint[]? GeoMatchConstraint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalGeoMatchSetConfig), fullyQualifiedName: "aws.WafregionalGeoMatchSetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IWafregionalGeoMatchSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>geo_match_constraint block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoMatchConstraint", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WafregionalGeoMatchSetGeoMatchConstraint\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWafregionalGeoMatchSetGeoMatchConstraint[]? GeoMatchConstraint
            {
                get => GetInstanceProperty<aws.IWafregionalGeoMatchSetGeoMatchConstraint[]?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsPricingProductConfig), fullyQualifiedName: "aws.DataAwsPricingProductConfig")]
    public interface IDataAwsPricingProductConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>filters block.</summary>
        [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsPricingProductFilters\"},\"kind\":\"array\"}}")]
        aws.IDataAwsPricingProductFilters[] Filters
        {
            get;
        }

        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsPricingProductConfig), fullyQualifiedName: "aws.DataAwsPricingProductConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsPricingProductConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filters block.</summary>
            [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsPricingProductFilters\"},\"kind\":\"array\"}}")]
            public aws.IDataAwsPricingProductFilters[] Filters
            {
                get => GetInstanceProperty<aws.IDataAwsPricingProductFilters[]>()!;
            }

            [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceCode
            {
                get => GetInstanceProperty<string>()!;
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

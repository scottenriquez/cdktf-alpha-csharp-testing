using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayDocumentationPartConfig), fullyQualifiedName: "aws.ApiGatewayDocumentationPartConfig")]
    public interface IApiGatewayDocumentationPartConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>location block.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayDocumentationPartLocation\"},\"kind\":\"array\"}}")]
        aws.IApiGatewayDocumentationPartLocation[] Location
        {
            get;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"primitive\":\"string\"}")]
        string Properties
        {
            get;
        }

        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayDocumentationPartConfig), fullyQualifiedName: "aws.ApiGatewayDocumentationPartConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayDocumentationPartConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>location block.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayDocumentationPartLocation\"},\"kind\":\"array\"}}")]
            public aws.IApiGatewayDocumentationPartLocation[] Location
            {
                get => GetInstanceProperty<aws.IApiGatewayDocumentationPartLocation[]>()!;
            }

            [JsiiProperty(name: "properties", typeJson: "{\"primitive\":\"string\"}")]
            public string Properties
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
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

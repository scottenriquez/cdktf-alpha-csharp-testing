using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApiGatewayMethodSettingsConfig), fullyQualifiedName: "aws.ApiGatewayMethodSettingsConfig")]
    public interface IApiGatewayMethodSettingsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "methodPath", typeJson: "{\"primitive\":\"string\"}")]
        string MethodPath
        {
            get;
        }

        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        /// <summary>settings block.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayMethodSettingsSettings\"},\"kind\":\"array\"}}")]
        aws.IApiGatewayMethodSettingsSettings[] Settings
        {
            get;
        }

        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        string StageName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiGatewayMethodSettingsConfig), fullyQualifiedName: "aws.ApiGatewayMethodSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IApiGatewayMethodSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "methodPath", typeJson: "{\"primitive\":\"string\"}")]
            public string MethodPath
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>settings block.</summary>
            [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayMethodSettingsSettings\"},\"kind\":\"array\"}}")]
            public aws.IApiGatewayMethodSettingsSettings[] Settings
            {
                get => GetInstanceProperty<aws.IApiGatewayMethodSettingsSettings[]>()!;
            }

            [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
            public string StageName
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

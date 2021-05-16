using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2AuthorizerConfig), fullyQualifiedName: "aws.Apigatewayv2AuthorizerConfig")]
    public interface IApigatewayv2AuthorizerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizerType
        {
            get;
        }

        [JsiiProperty(name: "identitySources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IdentitySources
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "authorizerCredentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizerCredentialsArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizerUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>jwt_configuration block.</summary>
        [JsiiProperty(name: "jwtConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2AuthorizerJwtConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IApigatewayv2AuthorizerJwtConfiguration[]? JwtConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2AuthorizerConfig), fullyQualifiedName: "aws.Apigatewayv2AuthorizerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2AuthorizerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizerType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "identitySources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IdentitySources
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "authorizerCredentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizerCredentialsArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizerUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>jwt_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jwtConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2AuthorizerJwtConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IApigatewayv2AuthorizerJwtConfiguration[]? JwtConfiguration
            {
                get => GetInstanceProperty<aws.IApigatewayv2AuthorizerJwtConfiguration[]?>();
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

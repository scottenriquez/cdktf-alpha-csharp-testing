using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2Authorizer), fullyQualifiedName: "aws.Apigatewayv2Authorizer", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Apigatewayv2AuthorizerConfig\"}}]")]
    public class Apigatewayv2Authorizer : HashiCorp.Cdktf.TerraformResource
    {
        public Apigatewayv2Authorizer(Constructs.Construct scope, string id, aws.IApigatewayv2AuthorizerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Authorizer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Authorizer(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthorizerCredentialsArn")]
        public virtual void ResetAuthorizerCredentialsArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorizerUri")]
        public virtual void ResetAuthorizerUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtConfiguration")]
        public virtual void ResetJwtConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizerTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identitySourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdentitySourcesInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerCredentialsArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerCredentialsArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2AuthorizerJwtConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApigatewayv2AuthorizerJwtConfiguration[]? JwtConfigurationInput
        {
            get => GetInstanceProperty<aws.IApigatewayv2AuthorizerJwtConfiguration[]?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerCredentialsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerCredentialsArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identitySources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdentitySources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2AuthorizerJwtConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IApigatewayv2AuthorizerJwtConfiguration[] JwtConfiguration
        {
            get => GetInstanceProperty<aws.IApigatewayv2AuthorizerJwtConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

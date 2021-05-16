using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ApiGatewayMethod), fullyQualifiedName: "aws.ApiGatewayMethod", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ApiGatewayMethodConfig\"}}]")]
    public class ApiGatewayMethod : HashiCorp.Cdktf.TerraformResource
    {
        public ApiGatewayMethod(Constructs.Construct scope, string id, aws.IApiGatewayMethodConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayMethod(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayMethod(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetApiKeyRequired")]
        public virtual void ResetApiKeyRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorizationScopes")]
        public virtual void ResetAuthorizationScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorizerId")]
        public virtual void ResetAuthorizerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestModels")]
        public virtual void ResetRequestModels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestParameters")]
        public virtual void ResetRequestParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestParametersInJson")]
        public virtual void ResetRequestParametersInJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestValidatorId")]
        public virtual void ResetRequestValidatorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpMethodInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpMethodInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restApiIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestApiIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyRequiredInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ApiKeyRequiredInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationScopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AuthorizationScopesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestModelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? RequestModelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestParametersInJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestParametersInJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"boolean\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, bool>? RequestParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, bool>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestValidatorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestValidatorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiKeyRequired", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ApiKeyRequired
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizationScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthorizationScopes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> RequestModels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"boolean\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, bool> RequestParameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, bool>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestParametersInJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestParametersInJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestValidatorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestValidatorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

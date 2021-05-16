using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AppsyncGraphqlApi), fullyQualifiedName: "aws.AppsyncGraphqlApi", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AppsyncGraphqlApiConfig\"}}]")]
    public class AppsyncGraphqlApi : HashiCorp.Cdktf.TerraformResource
    {
        public AppsyncGraphqlApi(Constructs.Construct scope, string id, aws.IAppsyncGraphqlApiConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApi(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApi(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdditionalAuthenticationProvider")]
        public virtual void ResetAdditionalAuthenticationProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfig")]
        public virtual void ResetLogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenidConnectConfig")]
        public virtual void ResetOpenidConnectConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchema")]
        public virtual void ResetSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolConfig")]
        public virtual void ResetUserPoolConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXrayEnabled")]
        public virtual void ResetXrayEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "uris", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string Uris(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalAuthenticationProviderInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]? AdditionalAuthenticationProviderInput
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiLogConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncGraphqlApiLogConfig[]? LogConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiLogConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiOpenidConnectConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncGraphqlApiOpenidConnectConfig[]? OpenidConnectConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiOpenidConnectConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiUserPoolConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAppsyncGraphqlApiUserPoolConfig[]? UserPoolConfigInput
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiUserPoolConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xrayEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? XrayEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[] AdditionalAuthenticationProvider
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiAdditionalAuthenticationProvider[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiLogConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncGraphqlApiLogConfig[] LogConfig
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiLogConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiOpenidConnectConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncGraphqlApiOpenidConnectConfig[] OpenidConnectConfig
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiOpenidConnectConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schema
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppsyncGraphqlApiUserPoolConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IAppsyncGraphqlApiUserPoolConfig[] UserPoolConfig
        {
            get => GetInstanceProperty<aws.IAppsyncGraphqlApiUserPoolConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xrayEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool XrayEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}

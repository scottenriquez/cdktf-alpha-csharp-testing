using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2Stage), fullyQualifiedName: "aws.Apigatewayv2Stage", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Apigatewayv2StageConfig\"}}]")]
    public class Apigatewayv2Stage : HashiCorp.Cdktf.TerraformResource
    {
        public Apigatewayv2Stage(Constructs.Construct scope, string id, aws.IApigatewayv2StageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Stage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Stage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessLogSettings")]
        public virtual void ResetAccessLogSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoDeploy")]
        public virtual void ResetAutoDeploy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateId")]
        public virtual void ResetClientCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultRouteSettings")]
        public virtual void ResetDefaultRouteSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentId")]
        public virtual void ResetDeploymentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteSettings")]
        public virtual void ResetRouteSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageVariables")]
        public virtual void ResetStageVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invokeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLogSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageAccessLogSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApigatewayv2StageAccessLogSettings[]? AccessLogSettingsInput
        {
            get => GetInstanceProperty<aws.IApigatewayv2StageAccessLogSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoDeployInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AutoDeployInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRouteSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageDefaultRouteSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApigatewayv2StageDefaultRouteSettings[]? DefaultRouteSettingsInput
        {
            get => GetInstanceProperty<aws.IApigatewayv2StageDefaultRouteSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApigatewayv2StageRouteSettings[]? RouteSettingsInput
        {
            get => GetInstanceProperty<aws.IApigatewayv2StageRouteSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? StageVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageAccessLogSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApigatewayv2StageAccessLogSettings[] AccessLogSettings
        {
            get => GetInstanceProperty<aws.IApigatewayv2StageAccessLogSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoDeploy", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AutoDeploy
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultRouteSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageDefaultRouteSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApigatewayv2StageDefaultRouteSettings[] DefaultRouteSettings
        {
            get => GetInstanceProperty<aws.IApigatewayv2StageDefaultRouteSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routeSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApigatewayv2StageRouteSettings[] RouteSettings
        {
            get => GetInstanceProperty<aws.IApigatewayv2StageRouteSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> StageVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

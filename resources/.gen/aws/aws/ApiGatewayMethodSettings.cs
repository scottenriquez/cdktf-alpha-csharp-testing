using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ApiGatewayMethodSettings), fullyQualifiedName: "aws.ApiGatewayMethodSettings", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ApiGatewayMethodSettingsConfig\"}}]")]
    public class ApiGatewayMethodSettings : HashiCorp.Cdktf.TerraformResource
    {
        public ApiGatewayMethodSettings(Constructs.Construct scope, string id, aws.IApiGatewayMethodSettingsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayMethodSettings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayMethodSettings(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "methodPathInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MethodPathInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restApiIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestApiIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "settingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayMethodSettingsSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayMethodSettingsSettings[] SettingsInput
        {
            get => GetInstanceProperty<aws.IApiGatewayMethodSettingsSettings[]>()!;
        }

        [JsiiProperty(name: "stageNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StageNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "methodPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MethodPath
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

        [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayMethodSettingsSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayMethodSettingsSettings[] Settings
        {
            get => GetInstanceProperty<aws.IApiGatewayMethodSettingsSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

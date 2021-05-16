using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ApiGatewayUsagePlan), fullyQualifiedName: "aws.ApiGatewayUsagePlan", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ApiGatewayUsagePlanConfig\"}}]")]
    public class ApiGatewayUsagePlan : HashiCorp.Cdktf.TerraformResource
    {
        public ApiGatewayUsagePlan(Constructs.Construct scope, string id, aws.IApiGatewayUsagePlanConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlan(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetApiStages")]
        public virtual void ResetApiStages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductCode")]
        public virtual void ResetProductCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuotaSettings")]
        public virtual void ResetQuotaSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThrottleSettings")]
        public virtual void ResetThrottleSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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
        [JsiiProperty(name: "apiStagesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApiGatewayUsagePlanApiStages[]? ApiStagesInput
        {
            get => GetInstanceProperty<aws.IApiGatewayUsagePlanApiStages[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanQuotaSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApiGatewayUsagePlanQuotaSettings[]? QuotaSettingsInput
        {
            get => GetInstanceProperty<aws.IApiGatewayUsagePlanQuotaSettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throttleSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanThrottleSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IApiGatewayUsagePlanThrottleSettings[]? ThrottleSettingsInput
        {
            get => GetInstanceProperty<aws.IApiGatewayUsagePlanThrottleSettings[]?>();
        }

        [JsiiProperty(name: "apiStages", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayUsagePlanApiStages[] ApiStages
        {
            get => GetInstanceProperty<aws.IApiGatewayUsagePlanApiStages[]>()!;
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

        [JsiiProperty(name: "productCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quotaSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanQuotaSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayUsagePlanQuotaSettings[] QuotaSettings
        {
            get => GetInstanceProperty<aws.IApiGatewayUsagePlanQuotaSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throttleSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ApiGatewayUsagePlanThrottleSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IApiGatewayUsagePlanThrottleSettings[] ThrottleSettings
        {
            get => GetInstanceProperty<aws.IApiGatewayUsagePlanThrottleSettings[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}

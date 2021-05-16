using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.PinpointApp), fullyQualifiedName: "aws.PinpointApp", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.PinpointAppConfig\"}}]")]
    public class PinpointApp : HashiCorp.Cdktf.TerraformResource
    {
        public PinpointApp(Constructs.Construct scope, string id, aws.IPinpointAppConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PinpointApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PinpointApp(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCampaignHook")]
        public virtual void ResetCampaignHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuietTime")]
        public virtual void ResetQuietTime()
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

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "campaignHookInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppCampaignHook\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IPinpointAppCampaignHook[]? CampaignHookInput
        {
            get => GetInstanceProperty<aws.IPinpointAppCampaignHook[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppLimits\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IPinpointAppLimits[]? LimitsInput
        {
            get => GetInstanceProperty<aws.IPinpointAppLimits[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quietTimeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppQuietTime\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IPinpointAppQuietTime[]? QuietTimeInput
        {
            get => GetInstanceProperty<aws.IPinpointAppQuietTime[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "campaignHook", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppCampaignHook\"},\"kind\":\"array\"}}")]
        public virtual aws.IPinpointAppCampaignHook[] CampaignHook
        {
            get => GetInstanceProperty<aws.IPinpointAppCampaignHook[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppLimits\"},\"kind\":\"array\"}}")]
        public virtual aws.IPinpointAppLimits[] Limits
        {
            get => GetInstanceProperty<aws.IPinpointAppLimits[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quietTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppQuietTime\"},\"kind\":\"array\"}}")]
        public virtual aws.IPinpointAppQuietTime[] QuietTime
        {
            get => GetInstanceProperty<aws.IPinpointAppQuietTime[]>()!;
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

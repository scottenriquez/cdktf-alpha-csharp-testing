using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.StoragegatewayGateway), fullyQualifiedName: "aws.StoragegatewayGateway", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.StoragegatewayGatewayConfig\"}}]")]
    public class StoragegatewayGateway : HashiCorp.Cdktf.TerraformResource
    {
        public StoragegatewayGateway(Constructs.Construct scope, string id, aws.IStoragegatewayGatewayConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGateway(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActivationKey")]
        public virtual void ResetActivationKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLogGroupArn")]
        public virtual void ResetCloudwatchLogGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayIpAddress")]
        public virtual void ResetGatewayIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayType")]
        public virtual void ResetGatewayType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayVpcEndpoint")]
        public virtual void ResetGatewayVpcEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMediumChangerType")]
        public virtual void ResetMediumChangerType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbActiveDirectorySettings")]
        public virtual void ResetSmbActiveDirectorySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbGuestPassword")]
        public virtual void ResetSmbGuestPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTapeDriveType")]
        public virtual void ResetTapeDriveType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayTimezoneInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayTimezoneInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActivationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayVpcEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayVpcEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediumChangerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediumChangerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbActiveDirectorySettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayGatewaySmbActiveDirectorySettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]? SmbActiveDirectorySettingsInput
        {
            get => GetInstanceProperty<aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbGuestPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmbGuestPasswordInput
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
        [JsiiProperty(name: "tapeDriveTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TapeDriveTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
        public virtual aws.IStoragegatewayGatewayTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IStoragegatewayGatewayTimeouts?>();
        }

        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayTimezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayVpcEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediumChangerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayGatewaySmbActiveDirectorySettings\"},\"kind\":\"array\"}}")]
        public virtual aws.IStoragegatewayGatewaySmbActiveDirectorySettings[] SmbActiveDirectorySettings
        {
            get => GetInstanceProperty<aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmbGuestPassword
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

        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TapeDriveType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayGatewayTimeouts\"}")]
        public virtual aws.IStoragegatewayGatewayTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IStoragegatewayGatewayTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}

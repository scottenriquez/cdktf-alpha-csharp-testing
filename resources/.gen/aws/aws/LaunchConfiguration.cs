using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LaunchConfiguration), fullyQualifiedName: "aws.LaunchConfiguration", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LaunchConfigurationConfig\"}}]")]
    public class LaunchConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        public LaunchConfiguration(Constructs.Construct scope, string id, aws.ILaunchConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAssociatePublicIpAddress")]
        public virtual void ResetAssociatePublicIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsBlockDevice")]
        public virtual void ResetEbsBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptimized")]
        public virtual void ResetEbsOptimized()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableMonitoring")]
        public virtual void ResetEnableMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralBlockDevice")]
        public virtual void ResetEphemeralBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamInstanceProfile")]
        public virtual void ResetIamInstanceProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyName")]
        public virtual void ResetKeyName()
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

        [JsiiMethod(name: "resetPlacementTenancy")]
        public virtual void ResetPlacementTenancy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootBlockDevice")]
        public virtual void ResetRootBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotPrice")]
        public virtual void ResetSpotPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserData")]
        public virtual void ResetUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserDataBase64")]
        public virtual void ResetUserDataBase64()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcClassicLinkId")]
        public virtual void ResetVpcClassicLinkId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcClassicLinkSecurityGroups")]
        public virtual void ResetVpcClassicLinkSecurityGroups()
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

        [JsiiProperty(name: "imageIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatePublicIpAddressInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? AssociatePublicIpAddressInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchConfigurationEbsBlockDevice[]? EbsBlockDeviceInput
        {
            get => GetInstanceProperty<aws.ILaunchConfigurationEbsBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EbsOptimizedInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableMonitoringInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableMonitoringInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchConfigurationEphemeralBlockDevice[]? EphemeralBlockDeviceInput
        {
            get => GetInstanceProperty<aws.ILaunchConfigurationEphemeralBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamInstanceProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyNameInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "placementTenancyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlacementTenancyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchConfigurationRootBlockDevice[]? RootBlockDeviceInput
        {
            get => GetInstanceProperty<aws.ILaunchConfigurationRootBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotPriceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotPriceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataBase64Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDataBase64Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcClassicLinkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcClassicLinkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcClassicLinkSecurityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcClassicLinkSecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AssociatePublicIpAddress
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationEbsBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchConfigurationEbsBlockDevice[] EbsBlockDevice
        {
            get => GetInstanceProperty<aws.ILaunchConfigurationEbsBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EbsOptimized
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableMonitoring", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableMonitoring
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationEphemeralBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchConfigurationEphemeralBlockDevice[] EphemeralBlockDevice
        {
            get => GetInstanceProperty<aws.ILaunchConfigurationEphemeralBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamInstanceProfile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementTenancy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationRootBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchConfigurationRootBlockDevice[] RootBlockDevice
        {
            get => GetInstanceProperty<aws.ILaunchConfigurationRootBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotPrice
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserDataBase64
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcClassicLinkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcClassicLinkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcClassicLinkSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcClassicLinkSecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}

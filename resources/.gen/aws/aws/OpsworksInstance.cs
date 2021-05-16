using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.OpsworksInstance), fullyQualifiedName: "aws.OpsworksInstance", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.OpsworksInstanceConfig\"}}]")]
    public class OpsworksInstance : HashiCorp.Cdktf.TerraformResource
    {
        public OpsworksInstance(Constructs.Construct scope, string id, aws.IOpsworksInstanceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAgentVersion")]
        public virtual void ResetAgentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAmiId")]
        public virtual void ResetAmiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArchitecture")]
        public virtual void ResetArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoScalingType")]
        public virtual void ResetAutoScalingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreatedAt")]
        public virtual void ResetCreatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteEbs")]
        public virtual void ResetDeleteEbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteEip")]
        public virtual void ResetDeleteEip()
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

        [JsiiMethod(name: "resetEcsClusterArn")]
        public virtual void ResetEcsClusterArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticIp")]
        public virtual void ResetElasticIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralBlockDevice")]
        public virtual void ResetEphemeralBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostname")]
        public virtual void ResetHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInfrastructureClass")]
        public virtual void ResetInfrastructureClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstallUpdatesOnBoot")]
        public virtual void ResetInstallUpdatesOnBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceProfileArn")]
        public virtual void ResetInstanceProfileArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastServiceErrorId")]
        public virtual void ResetLastServiceErrorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOs")]
        public virtual void ResetOs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatform")]
        public virtual void ResetPlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDns")]
        public virtual void ResetPrivateDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIp")]
        public virtual void ResetPrivateIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicDns")]
        public virtual void ResetPublicDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicIp")]
        public virtual void ResetPublicIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegisteredBy")]
        public virtual void ResetRegisteredBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedAgentVersion")]
        public virtual void ResetReportedAgentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedOsFamily")]
        public virtual void ResetReportedOsFamily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedOsName")]
        public virtual void ResetReportedOsName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportedOsVersion")]
        public virtual void ResetReportedOsVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootBlockDevice")]
        public virtual void ResetRootBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDeviceType")]
        public virtual void ResetRootDeviceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDeviceVolumeId")]
        public virtual void ResetRootDeviceVolumeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshHostDsaKeyFingerprint")]
        public virtual void ResetSshHostDsaKeyFingerprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshHostRsaKeyFingerprint")]
        public virtual void ResetSshHostRsaKeyFingerprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshKeyName")]
        public virtual void ResetSshKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenancy")]
        public virtual void ResetTenancy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualizationType")]
        public virtual void ResetVirtualizationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "ec2InstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "layerIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LayerIdsInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "amiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AmiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "architectureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchitectureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createdAtInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreatedAtInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteEbsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? DeleteEbsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteEipInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? DeleteEipInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IOpsworksInstanceEbsBlockDevice[]? EbsBlockDeviceInput
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceEbsBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EbsOptimizedInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsClusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EcsClusterArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IOpsworksInstanceEphemeralBlockDevice[]? EphemeralBlockDeviceInput
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceEphemeralBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "installUpdatesOnBootInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? InstallUpdatesOnBootInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceProfileArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceProfileArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastServiceErrorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastServiceErrorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateDnsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicDnsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicDnsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registeredByInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegisteredByInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedAgentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedAgentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedOsFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedOsNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportedOsVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReportedOsVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IOpsworksInstanceRootBlockDevice[]? RootBlockDeviceInput
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceRootBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDeviceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceVolumeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDeviceVolumeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshHostDsaKeyFingerprintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshHostDsaKeyFingerprintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshHostRsaKeyFingerprintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshHostRsaKeyFingerprintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshKeyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshKeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenancyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.OpsworksInstanceTimeouts\"}", isOptional: true)]
        public virtual aws.IOpsworksInstanceTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualizationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualizationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "amiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoScalingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteEbs", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DeleteEbs
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteEip", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DeleteEip
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceEbsBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.IOpsworksInstanceEbsBlockDevice[] EbsBlockDevice
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceEbsBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EbsOptimized
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcsClusterArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceEphemeralBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.IOpsworksInstanceEphemeralBlockDevice[] EphemeralBlockDevice
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceEphemeralBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "infrastructureClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool InstallUpdatesOnBoot
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceProfileArn
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

        [JsiiProperty(name: "lastServiceErrorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastServiceErrorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "layerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LayerIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Os
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDns
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registeredBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegisteredBy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedAgentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedAgentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedOsFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedOsFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedOsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedOsName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportedOsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportedOsVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksInstanceRootBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.IOpsworksInstanceRootBlockDevice[] RootBlockDevice
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceRootBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDeviceVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceVolumeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshHostDsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshHostDsaKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshHostRsaKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshHostRsaKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshKeyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.OpsworksInstanceTimeouts\"}")]
        public virtual aws.IOpsworksInstanceTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IOpsworksInstanceTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualizationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

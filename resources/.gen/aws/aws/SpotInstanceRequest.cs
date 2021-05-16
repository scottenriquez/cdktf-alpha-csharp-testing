using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SpotInstanceRequest), fullyQualifiedName: "aws.SpotInstanceRequest", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SpotInstanceRequestConfig\"}}]")]
    public class SpotInstanceRequest : HashiCorp.Cdktf.TerraformResource
    {
        public SpotInstanceRequest(Constructs.Construct scope, string id, aws.ISpotInstanceRequestConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotInstanceRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotInstanceRequest(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAssociatePublicIpAddress")]
        public virtual void ResetAssociatePublicIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockDurationMinutes")]
        public virtual void ResetBlockDurationMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuCoreCount")]
        public virtual void ResetCpuCoreCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuThreadsPerCore")]
        public virtual void ResetCpuThreadsPerCore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreditSpecification")]
        public virtual void ResetCreditSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableApiTermination")]
        public virtual void ResetDisableApiTermination()
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

        [JsiiMethod(name: "resetEphemeralBlockDevice")]
        public virtual void ResetEphemeralBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFetchPasswordData")]
        public virtual void ResetFetchPasswordData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHibernation")]
        public virtual void ResetHibernation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostId")]
        public virtual void ResetHostId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamInstanceProfile")]
        public virtual void ResetIamInstanceProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInitiatedShutdownBehavior")]
        public virtual void ResetInstanceInitiatedShutdownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInterruptionBehaviour")]
        public virtual void ResetInstanceInterruptionBehaviour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6AddressCount")]
        public virtual void ResetIpv6AddressCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpv6Addresses")]
        public virtual void ResetIpv6Addresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyName")]
        public virtual void ResetKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchGroup")]
        public virtual void ResetLaunchGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadataOptions")]
        public virtual void ResetMetadataOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoring")]
        public virtual void ResetMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterface")]
        public virtual void ResetNetworkInterface()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementGroup")]
        public virtual void ResetPlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIp")]
        public virtual void ResetPrivateIp()
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

        [JsiiMethod(name: "resetSourceDestCheck")]
        public virtual void ResetSourceDestCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotPrice")]
        public virtual void ResetSpotPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotType")]
        public virtual void ResetSpotType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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

        [JsiiMethod(name: "resetValidFrom")]
        public virtual void ResetValidFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidUntil")]
        public virtual void ResetValidUntil()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeTags")]
        public virtual void ResetVolumeTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcSecurityGroupIds")]
        public virtual void ResetVpcSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForFulfillment")]
        public virtual void ResetWaitForFulfillment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "amiInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmiInput
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

        [JsiiProperty(name: "instanceState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outpostArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutpostArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryNetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spotBidStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotBidStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spotInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spotRequestState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotRequestState
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
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockDurationMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlockDurationMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCoreCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuCoreCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuThreadsPerCoreInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuThreadsPerCoreInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestCreditSpecification[]? CreditSpecificationInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestCreditSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiTerminationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? DisableApiTerminationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestEbsBlockDevice[]? EbsBlockDeviceInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestEbsBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EbsOptimizedInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestEphemeralBlockDevice[]? EphemeralBlockDeviceInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestEphemeralBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchPasswordDataInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? FetchPasswordDataInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hibernationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? HibernationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamInstanceProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInitiatedShutdownBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehaviourInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInterruptionBehaviourInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Ipv6AddressCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Ipv6AddressesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestMetadataOptions[]? MetadataOptionsInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestMetadataOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? MonitoringInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestNetworkInterface[]? NetworkInterfaceInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestNetworkInterface[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlacementGroupInput
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
        [JsiiProperty(name: "rootBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestRootBlockDevice[]? RootBlockDeviceInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestRootBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDestCheckInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? SourceDestCheckInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotPriceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotPriceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotTypeInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenancyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.SpotInstanceRequestTimeouts\"}", isOptional: true)]
        public virtual aws.ISpotInstanceRequestTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestTimeouts?>();
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
        [JsiiProperty(name: "validFromInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValidFromInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validUntilInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValidUntilInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VolumeTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForFulfillmentInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? WaitForFulfillmentInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ami
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AssociatePublicIpAddress
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockDurationMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuThreadsPerCore
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestCreditSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotInstanceRequestCreditSpecification[] CreditSpecification
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestCreditSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DisableApiTermination
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotInstanceRequestEbsBlockDevice[] EbsBlockDevice
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestEbsBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EbsOptimized
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotInstanceRequestEphemeralBlockDevice[] EphemeralBlockDevice
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestEphemeralBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool FetchPasswordData
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hibernation", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Hibernation
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamInstanceProfile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInterruptionBehaviour
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

        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ipv6AddressCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Ipv6Addresses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestMetadataOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotInstanceRequestMetadataOptions[] MetadataOptions
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestMetadataOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Monitoring
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotInstanceRequestNetworkInterface[] NetworkInterface
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestNetworkInterface[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
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

        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotInstanceRequestRootBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotInstanceRequestRootBlockDevice[] RootBlockDevice
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestRootBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool SourceDestCheck
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotPrice
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotType
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.SpotInstanceRequestTimeouts\"}")]
        public virtual aws.ISpotInstanceRequestTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.ISpotInstanceRequestTimeouts>()!;
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

        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidFrom
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidUntil
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> VolumeTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool WaitForFulfillment
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}

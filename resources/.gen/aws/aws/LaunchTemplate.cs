using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate), fullyQualifiedName: "aws.LaunchTemplate", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.LaunchTemplateConfig\"}}]")]
    public class LaunchTemplate : HashiCorp.Cdktf.TerraformResource
    {
        public LaunchTemplate(Constructs.Construct scope, string id, aws.ILaunchTemplateConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBlockDeviceMappings")]
        public virtual void ResetBlockDeviceMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationSpecification")]
        public virtual void ResetCapacityReservationSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuOptions")]
        public virtual void ResetCpuOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreditSpecification")]
        public virtual void ResetCreditSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultVersion")]
        public virtual void ResetDefaultVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableApiTermination")]
        public virtual void ResetDisableApiTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptimized")]
        public virtual void ResetEbsOptimized()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticGpuSpecifications")]
        public virtual void ResetElasticGpuSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticInferenceAccelerator")]
        public virtual void ResetElasticInferenceAccelerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHibernationOptions")]
        public virtual void ResetHibernationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamInstanceProfile")]
        public virtual void ResetIamInstanceProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageId")]
        public virtual void ResetImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInitiatedShutdownBehavior")]
        public virtual void ResetInstanceInitiatedShutdownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceMarketOptions")]
        public virtual void ResetInstanceMarketOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelId")]
        public virtual void ResetKernelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyName")]
        public virtual void ResetKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseSpecification")]
        public virtual void ResetLicenseSpecification()
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

        [JsiiMethod(name: "resetNetworkInterfaces")]
        public virtual void ResetNetworkInterfaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRamDiskId")]
        public virtual void ResetRamDiskId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupNames")]
        public virtual void ResetSecurityGroupNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagSpecifications")]
        public virtual void ResetTagSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateDefaultVersion")]
        public virtual void ResetUpdateDefaultVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserData")]
        public virtual void ResetUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcSecurityGroupIds")]
        public virtual void ResetVpcSecurityGroupIds()
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

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMappingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateBlockDeviceMappings[]? BlockDeviceMappingsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateBlockDeviceMappings[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateCapacityReservationSpecification[]? CapacityReservationSpecificationInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateCapacityReservationSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCpuOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateCpuOptions[]? CpuOptionsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateCpuOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateCreditSpecification[]? CreditSpecificationInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateCreditSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiTerminationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? DisableApiTerminationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EbsOptimizedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticGpuSpecificationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateElasticGpuSpecifications[]? ElasticGpuSpecificationsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateElasticGpuSpecifications[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticInferenceAcceleratorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateElasticInferenceAccelerator[]? ElasticInferenceAcceleratorInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateElasticInferenceAccelerator[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hibernationOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateHibernationOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateHibernationOptions[]? HibernationOptionsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateHibernationOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfileInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateIamInstanceProfile\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateIamInstanceProfile[]? IamInstanceProfileInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateIamInstanceProfile[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdInput
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
        [JsiiProperty(name: "instanceMarketOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateInstanceMarketOptions[]? InstanceMarketOptionsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateInstanceMarketOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KernelIdInput
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
        [JsiiProperty(name: "licenseSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateLicenseSpecification[]? LicenseSpecificationInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateLicenseSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateMetadataOptions[]? MetadataOptionsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateMetadataOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMonitoring\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateMonitoring[]? MonitoringInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateMonitoring[]?>();
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
        [JsiiProperty(name: "networkInterfacesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateNetworkInterfaces[]? NetworkInterfacesInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateNetworkInterfaces[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplatePlacement\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplatePlacement[]? PlacementInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplatePlacement[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramDiskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RamDiskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagSpecificationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILaunchTemplateTagSpecifications[]? TagSpecificationsInput
        {
            get => GetInstanceProperty<aws.ILaunchTemplateTagSpecifications[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateDefaultVersionInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? UpdateDefaultVersionInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateBlockDeviceMappings[] BlockDeviceMappings
        {
            get => GetInstanceProperty<aws.ILaunchTemplateBlockDeviceMappings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateCapacityReservationSpecification[] CapacityReservationSpecification
        {
            get => GetInstanceProperty<aws.ILaunchTemplateCapacityReservationSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCpuOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateCpuOptions[] CpuOptions
        {
            get => GetInstanceProperty<aws.ILaunchTemplateCpuOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCreditSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateCreditSpecification[] CreditSpecification
        {
            get => GetInstanceProperty<aws.ILaunchTemplateCreditSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DisableApiTermination
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateElasticGpuSpecifications[] ElasticGpuSpecifications
        {
            get => GetInstanceProperty<aws.ILaunchTemplateElasticGpuSpecifications[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticInferenceAccelerator\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateElasticInferenceAccelerator[] ElasticInferenceAccelerator
        {
            get => GetInstanceProperty<aws.ILaunchTemplateElasticInferenceAccelerator[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateHibernationOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateHibernationOptions[] HibernationOptions
        {
            get => GetInstanceProperty<aws.ILaunchTemplateHibernationOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateIamInstanceProfile\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateIamInstanceProfile[] IamInstanceProfile
        {
            get => GetInstanceProperty<aws.ILaunchTemplateIamInstanceProfile[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
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

        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateInstanceMarketOptions[] InstanceMarketOptions
        {
            get => GetInstanceProperty<aws.ILaunchTemplateInstanceMarketOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
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

        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateLicenseSpecification[] LicenseSpecification
        {
            get => GetInstanceProperty<aws.ILaunchTemplateLicenseSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMetadataOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateMetadataOptions[] MetadataOptions
        {
            get => GetInstanceProperty<aws.ILaunchTemplateMetadataOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMonitoring\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateMonitoring[] Monitoring
        {
            get => GetInstanceProperty<aws.ILaunchTemplateMonitoring[]>()!;
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

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateNetworkInterfaces[] NetworkInterfaces
        {
            get => GetInstanceProperty<aws.ILaunchTemplateNetworkInterfaces[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplatePlacement\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplatePlacement[] Placement
        {
            get => GetInstanceProperty<aws.ILaunchTemplatePlacement[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}")]
        public virtual aws.ILaunchTemplateTagSpecifications[] TagSpecifications
        {
            get => GetInstanceProperty<aws.ILaunchTemplateTagSpecifications[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool UpdateDefaultVersion
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateConfig), fullyQualifiedName: "aws.LaunchTemplateConfig")]
    public interface ILaunchTemplateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>block_device_mappings block.</summary>
        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateBlockDeviceMappings[]? BlockDeviceMappings
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity_reservation_specification block.</summary>
        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateCapacityReservationSpecification[]? CapacityReservationSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>cpu_options block.</summary>
        [JsiiProperty(name: "cpuOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCpuOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateCpuOptions[]? CpuOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>credit_specification block.</summary>
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateCreditSpecification[]? CreditSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DisableApiTermination
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EbsOptimized
        {
            get
            {
                return null;
            }
        }

        /// <summary>elastic_gpu_specifications block.</summary>
        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateElasticGpuSpecifications[]? ElasticGpuSpecifications
        {
            get
            {
                return null;
            }
        }

        /// <summary>elastic_inference_accelerator block.</summary>
        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateElasticInferenceAccelerator[]? ElasticInferenceAccelerator
        {
            get
            {
                return null;
            }
        }

        /// <summary>hibernation_options block.</summary>
        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateHibernationOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateHibernationOptions[]? HibernationOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>iam_instance_profile block.</summary>
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateIamInstanceProfile\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateIamInstanceProfile[]? IamInstanceProfile
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceInitiatedShutdownBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_market_options block.</summary>
        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateInstanceMarketOptions[]? InstanceMarketOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KernelId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>license_specification block.</summary>
        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateLicenseSpecification[]? LicenseSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>metadata_options block.</summary>
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateMetadataOptions[]? MetadataOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitoring block.</summary>
        [JsiiProperty(name: "monitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMonitoring\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateMonitoring[]? Monitoring
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interfaces block.</summary>
        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateNetworkInterfaces[]? NetworkInterfaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement block.</summary>
        [JsiiProperty(name: "placement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplatePlacement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplatePlacement[]? Placement
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RamDiskId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupNames
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_specifications block.</summary>
        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ILaunchTemplateTagSpecifications[]? TagSpecifications
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UpdateDefaultVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateConfig), fullyQualifiedName: "aws.LaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>block_device_mappings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateBlockDeviceMappings[]? BlockDeviceMappings
            {
                get => GetInstanceProperty<aws.ILaunchTemplateBlockDeviceMappings[]?>();
            }

            /// <summary>capacity_reservation_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateCapacityReservationSpecification[]? CapacityReservationSpecification
            {
                get => GetInstanceProperty<aws.ILaunchTemplateCapacityReservationSpecification[]?>();
            }

            /// <summary>cpu_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCpuOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateCpuOptions[]? CpuOptions
            {
                get => GetInstanceProperty<aws.ILaunchTemplateCpuOptions[]?>();
            }

            /// <summary>credit_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateCreditSpecification[]? CreditSpecification
            {
                get => GetInstanceProperty<aws.ILaunchTemplateCreditSpecification[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultVersion
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DisableApiTermination
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EbsOptimized
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>elastic_gpu_specifications block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateElasticGpuSpecifications[]? ElasticGpuSpecifications
            {
                get => GetInstanceProperty<aws.ILaunchTemplateElasticGpuSpecifications[]?>();
            }

            /// <summary>elastic_inference_accelerator block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateElasticInferenceAccelerator[]? ElasticInferenceAccelerator
            {
                get => GetInstanceProperty<aws.ILaunchTemplateElasticInferenceAccelerator[]?>();
            }

            /// <summary>hibernation_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hibernationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateHibernationOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateHibernationOptions[]? HibernationOptions
            {
                get => GetInstanceProperty<aws.ILaunchTemplateHibernationOptions[]?>();
            }

            /// <summary>iam_instance_profile block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateIamInstanceProfile\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateIamInstanceProfile[]? IamInstanceProfile
            {
                get => GetInstanceProperty<aws.ILaunchTemplateIamInstanceProfile[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceInitiatedShutdownBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_market_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateInstanceMarketOptions[]? InstanceMarketOptions
            {
                get => GetInstanceProperty<aws.ILaunchTemplateInstanceMarketOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KernelId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>license_specification block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateLicenseSpecification[]? LicenseSpecification
            {
                get => GetInstanceProperty<aws.ILaunchTemplateLicenseSpecification[]?>();
            }

            /// <summary>metadata_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateMetadataOptions[]? MetadataOptions
            {
                get => GetInstanceProperty<aws.ILaunchTemplateMetadataOptions[]?>();
            }

            /// <summary>monitoring block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMonitoring\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateMonitoring[]? Monitoring
            {
                get => GetInstanceProperty<aws.ILaunchTemplateMonitoring[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_interfaces block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaces", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateNetworkInterfaces[]? NetworkInterfaces
            {
                get => GetInstanceProperty<aws.ILaunchTemplateNetworkInterfaces[]?>();
            }

            /// <summary>placement block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplatePlacement\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplatePlacement[]? Placement
            {
                get => GetInstanceProperty<aws.ILaunchTemplatePlacement[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RamDiskId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>tag_specifications block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ILaunchTemplateTagSpecifications[]? TagSpecifications
            {
                get => GetInstanceProperty<aws.ILaunchTemplateTagSpecifications[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UpdateDefaultVersion
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}

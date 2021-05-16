using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LaunchTemplateConfig")]
    public class LaunchTemplateConfig : aws.ILaunchTemplateConfig
    {
        /// <summary>block_device_mappings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateBlockDeviceMappings[]? BlockDeviceMappings
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCapacityReservationSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateCapacityReservationSpecification[]? CapacityReservationSpecification
        {
            get;
            set;
        }

        /// <summary>cpu_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCpuOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateCpuOptions[]? CpuOptions
        {
            get;
            set;
        }

        /// <summary>credit_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateCreditSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateCreditSpecification[]? CreditSpecification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DefaultVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? DisableApiTermination
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EbsOptimized
        {
            get;
            set;
        }

        /// <summary>elastic_gpu_specifications block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateElasticGpuSpecifications[]? ElasticGpuSpecifications
        {
            get;
            set;
        }

        /// <summary>elastic_inference_accelerator block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateElasticInferenceAccelerator\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateElasticInferenceAccelerator[]? ElasticInferenceAccelerator
        {
            get;
            set;
        }

        /// <summary>hibernation_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateHibernationOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateHibernationOptions[]? HibernationOptions
        {
            get;
            set;
        }

        /// <summary>iam_instance_profile block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateIamInstanceProfile\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateIamInstanceProfile[]? IamInstanceProfile
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ImageId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInitiatedShutdownBehavior
        {
            get;
            set;
        }

        /// <summary>instance_market_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateInstanceMarketOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateInstanceMarketOptions[]? InstanceMarketOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KernelId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>license_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateLicenseSpecification[]? LicenseSpecification
        {
            get;
            set;
        }

        /// <summary>metadata_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMetadataOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateMetadataOptions[]? MetadataOptions
        {
            get;
            set;
        }

        /// <summary>monitoring block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitoring", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateMonitoring\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateMonitoring[]? Monitoring
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>network_interfaces block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateNetworkInterfaces[]? NetworkInterfaces
        {
            get;
            set;
        }

        /// <summary>placement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplatePlacement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplatePlacement[]? Placement
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RamDiskId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroupNames
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>tag_specifications block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchTemplateTagSpecifications[]? TagSpecifications
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UpdateDefaultVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserData
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcSecurityGroupIds
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}

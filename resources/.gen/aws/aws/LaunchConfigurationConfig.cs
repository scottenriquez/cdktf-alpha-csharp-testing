using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LaunchConfigurationConfig")]
    public class LaunchConfigurationConfig : aws.ILaunchConfigurationConfig
    {
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ImageId
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AssociatePublicIpAddress
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchConfigurationEbsBlockDevice[]? EbsBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EbsOptimized
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableMonitoring", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableMonitoring
        {
            get;
            set;
        }

        /// <summary>ephemeral_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchConfigurationEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IamInstanceProfile
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

        [JsiiOptional]
        [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlacementTenancy
        {
            get;
            set;
        }

        /// <summary>root_block_device block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LaunchConfigurationRootBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILaunchConfigurationRootBlockDevice[]? RootBlockDevice
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotPrice
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
        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserDataBase64
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcClassicLinkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VpcClassicLinkId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcClassicLinkSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcClassicLinkSecurityGroups
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

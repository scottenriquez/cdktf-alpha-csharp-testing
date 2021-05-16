using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.OpsworksStackConfig")]
    public class OpsworksStackConfig : aws.IOpsworksStackConfig
    {
        [JsiiProperty(name: "defaultInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultInstanceProfileArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Region
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AgentVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "berkshelfVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BerkshelfVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Color
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationManagerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConfigurationManagerName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationManagerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConfigurationManagerVersion
        {
            get;
            set;
        }

        /// <summary>custom_cookbooks_source block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customCookbooksSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksStackCustomCookbooksSource\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IOpsworksStackCustomCookbooksSource[]? CustomCookbooksSource
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomJson
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultAvailabilityZone
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultOs", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultOs
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultRootDeviceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultSshKeyName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultSubnetId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameTheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostnameTheme
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "manageBerkshelf", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ManageBerkshelf
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

        [JsiiOptional]
        [JsiiProperty(name: "useCustomCookbooks", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UseCustomCookbooks
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "useOpsworksSecurityGroups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UseOpsworksSecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VpcId
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

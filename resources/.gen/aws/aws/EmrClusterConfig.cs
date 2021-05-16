using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EmrClusterConfig")]
    public class EmrClusterConfig : aws.IEmrClusterConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReleaseLabel
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRole
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdditionalInfo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Applications
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AutoscalingRole
        {
            get;
            set;
        }

        /// <summary>bootstrap_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterBootstrapAction[]? BootstrapAction
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Configurations
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConfigurationsJson
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CoreInstanceCount
        {
            get;
            set;
        }

        /// <summary>core_instance_group block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterCoreInstanceGroup[]? CoreInstanceGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CoreInstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomAmiId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? EbsRootVolumeSize
        {
            get;
            set;
        }

        /// <summary>ec2_attributes block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterEc2Attributes\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterEc2Attributes[]? Ec2Attributes
        {
            get;
            set;
        }

        /// <summary>instance_group block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterInstanceGroup[]? InstanceGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? KeepJobFlowAliveWhenNoSteps
        {
            get;
            set;
        }

        /// <summary>kerberos_attributes block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterKerberosAttributes\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterKerberosAttributes[]? KerberosAttributes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogUri
        {
            get;
            set;
        }

        /// <summary>master_instance_group block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterMasterInstanceGroup[]? MasterInstanceGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MasterInstanceType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ScaleDownBehavior
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "step", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStep\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEmrClusterStep[]? Step
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? StepConcurrencyLevel
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
        [JsiiProperty(name: "terminationProtection", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? TerminationProtection
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? VisibleToAllUsers
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

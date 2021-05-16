using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2FleetConfig")]
    public class Ec2FleetConfig : aws.IEc2FleetConfig
    {
        /// <summary>launch_template_config block.</summary>
        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfig\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IEc2FleetLaunchTemplateConfig[] LaunchTemplateConfig
        {
            get;
            set;
        }

        /// <summary>target_capacity_specification block.</summary>
        [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetTargetCapacitySpecification\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IEc2FleetTargetCapacitySpecification[] TargetCapacitySpecification
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ExcessCapacityTerminationPolicy
        {
            get;
            set;
        }

        /// <summary>on_demand_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetOnDemandOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEc2FleetOnDemandOptions[]? OnDemandOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ReplaceUnhealthyInstances
        {
            get;
            set;
        }

        /// <summary>spot_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetSpotOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEc2FleetSpotOptions[]? SpotOptions
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
        [JsiiProperty(name: "terminateInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? TerminateInstances
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? TerminateInstancesWithExpiration
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.Ec2FleetTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IEc2FleetTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
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

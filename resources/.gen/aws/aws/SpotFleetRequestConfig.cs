using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SpotFleetRequestConfig")]
    public class SpotFleetRequestConfig : aws.ISpotFleetRequestConfig
    {
        [JsiiProperty(name: "iamFleetRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IamFleetRole
        {
            get;
            set;
        }

        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TargetCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AllocationStrategy
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

        [JsiiOptional]
        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FleetType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInterruptionBehaviour
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? InstancePoolsToUseCount
        {
            get;
            set;
        }

        /// <summary>launch_specification block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISpotFleetRequestLaunchSpecification[]? LaunchSpecification
        {
            get;
            set;
        }

        /// <summary>launch_template_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISpotFleetRequestLaunchTemplateConfig[]? LaunchTemplateConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? LoadBalancers
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

        [JsiiOptional]
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotPrice
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
        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? TargetGroupArns
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.SpotFleetRequestTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.ISpotFleetRequestTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ValidFrom
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ValidUntil
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? WaitForFulfillment
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

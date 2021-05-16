using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingGroupConfig")]
    public class AutoscalingGroupConfig : aws.IAutoscalingGroupConfig
    {
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxSize
        {
            get;
            set;
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MinSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AvailabilityZones
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DefaultCooldown
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DesiredCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? EnabledMetrics
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ForceDelete
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HealthCheckGracePeriod
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HealthCheckType
        {
            get;
            set;
        }

        /// <summary>initial_lifecycle_hook block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialLifecycleHook", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupInitialLifecycleHook[]? InitialLifecycleHook
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LaunchConfiguration
        {
            get;
            set;
        }

        /// <summary>launch_template block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupLaunchTemplate\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupLaunchTemplate[]? LaunchTemplate
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
        [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxInstanceLifetime
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsGranularity", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MetricsGranularity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "minElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MinElbCapacity
        {
            get;
            set;
        }

        /// <summary>mixed_instances_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupMixedInstancesPolicy[]? MixedInstancesPolicy
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
        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlacementGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectFromScaleIn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ProtectFromScaleIn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceLinkedRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SuspendedProcesses
        {
            get;
            set;
        }

        /// <summary>tag block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupTag\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupTag[]? Tag
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
        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? TerminationPolicies
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AutoscalingGroupTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IAutoscalingGroupTimeouts? Timeouts
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcZoneIdentifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForCapacityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WaitForCapacityTimeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForElbCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WaitForElbCapacity
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

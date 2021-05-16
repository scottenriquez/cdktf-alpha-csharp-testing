using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcsServiceConfig")]
    public class EcsServiceConfig : aws.IEcsServiceConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>capacity_provider_strategy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceCapacityProviderStrategy[]? CapacityProviderStrategy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Cluster
        {
            get;
            set;
        }

        /// <summary>deployment_controller block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentController", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceDeploymentController\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceDeploymentController[]? DeploymentController
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DeploymentMaximumPercent
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DeploymentMinimumHealthyPercent
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DesiredCount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableEcsManagedTags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ForceNewDeployment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HealthCheckGracePeriodSeconds
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IamRole
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LaunchType
        {
            get;
            set;
        }

        /// <summary>load_balancer block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceLoadBalancer[]? LoadBalancer
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceNetworkConfiguration[]? NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>ordered_placement_strategy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceOrderedPlacementStrategy[]? OrderedPlacementStrategy
        {
            get;
            set;
        }

        /// <summary>placement_constraints block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServicePlacementConstraints[]? PlacementConstraints
        {
            get;
            set;
        }

        /// <summary>placement_strategy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServicePlacementStrategy[]? PlacementStrategy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlatformVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PropagateTags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SchedulingStrategy
        {
            get;
            set;
        }

        /// <summary>service_registries block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceServiceRegistries\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceServiceRegistries[]? ServiceRegistries
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
        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TaskDefinition
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EcsServiceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IEcsServiceTimeouts? Timeouts
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

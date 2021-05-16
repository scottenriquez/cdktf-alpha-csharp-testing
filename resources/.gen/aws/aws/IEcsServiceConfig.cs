using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcsServiceConfig), fullyQualifiedName: "aws.EcsServiceConfig")]
    public interface IEcsServiceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>capacity_provider_strategy block.</summary>
        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceCapacityProviderStrategy[]? CapacityProviderStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment_controller block.</summary>
        [JsiiProperty(name: "deploymentController", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceDeploymentController\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceDeploymentController[]? DeploymentController
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeploymentMaximumPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeploymentMinimumHealthyPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnableEcsManagedTags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ForceNewDeployment
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamRole
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer block.</summary>
        [JsiiProperty(name: "loadBalancer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceLoadBalancer[]? LoadBalancer
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_configuration block.</summary>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceNetworkConfiguration[]? NetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>ordered_placement_strategy block.</summary>
        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceOrderedPlacementStrategy[]? OrderedPlacementStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_constraints block.</summary>
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServicePlacementConstraints[]? PlacementConstraints
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_strategy block.</summary>
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServicePlacementStrategy[]? PlacementStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropagateTags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchedulingStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_registries block.</summary>
        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceServiceRegistries\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceServiceRegistries[]? ServiceRegistries
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

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EcsServiceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEcsServiceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceConfig), fullyQualifiedName: "aws.EcsServiceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEcsServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>capacity_provider_strategy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServiceCapacityProviderStrategy[]? CapacityProviderStrategy
            {
                get => GetInstanceProperty<aws.IEcsServiceCapacityProviderStrategy[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cluster
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deployment_controller block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentController", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceDeploymentController\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServiceDeploymentController[]? DeploymentController
            {
                get => GetInstanceProperty<aws.IEcsServiceDeploymentController[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeploymentMaximumPercent
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeploymentMinimumHealthyPercent
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnableEcsManagedTags
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ForceNewDeployment
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckGracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamRole
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>load_balancer block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServiceLoadBalancer[]? LoadBalancer
            {
                get => GetInstanceProperty<aws.IEcsServiceLoadBalancer[]?>();
            }

            /// <summary>network_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServiceNetworkConfiguration[]? NetworkConfiguration
            {
                get => GetInstanceProperty<aws.IEcsServiceNetworkConfiguration[]?>();
            }

            /// <summary>ordered_placement_strategy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServiceOrderedPlacementStrategy[]? OrderedPlacementStrategy
            {
                get => GetInstanceProperty<aws.IEcsServiceOrderedPlacementStrategy[]?>();
            }

            /// <summary>placement_constraints block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServicePlacementConstraints[]? PlacementConstraints
            {
                get => GetInstanceProperty<aws.IEcsServicePlacementConstraints[]?>();
            }

            /// <summary>placement_strategy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServicePlacementStrategy[]? PlacementStrategy
            {
                get => GetInstanceProperty<aws.IEcsServicePlacementStrategy[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropagateTags
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchedulingStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service_registries block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRegistries", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceServiceRegistries\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEcsServiceServiceRegistries[]? ServiceRegistries
            {
                get => GetInstanceProperty<aws.IEcsServiceServiceRegistries[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskDefinition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EcsServiceTimeouts\"}", isOptional: true)]
            public aws.IEcsServiceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IEcsServiceTimeouts?>();
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

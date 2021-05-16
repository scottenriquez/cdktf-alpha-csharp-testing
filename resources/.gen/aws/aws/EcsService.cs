using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.EcsService), fullyQualifiedName: "aws.EcsService", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.EcsServiceConfig\"}}]")]
    public class EcsService : HashiCorp.Cdktf.TerraformResource
    {
        public EcsService(Constructs.Construct scope, string id, aws.IEcsServiceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsService(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCapacityProviderStrategy")]
        public virtual void ResetCapacityProviderStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCluster")]
        public virtual void ResetCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentController")]
        public virtual void ResetDeploymentController()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMaximumPercent")]
        public virtual void ResetDeploymentMaximumPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMinimumHealthyPercent")]
        public virtual void ResetDeploymentMinimumHealthyPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredCount")]
        public virtual void ResetDesiredCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableEcsManagedTags")]
        public virtual void ResetEnableEcsManagedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceNewDeployment")]
        public virtual void ResetForceNewDeployment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckGracePeriodSeconds")]
        public virtual void ResetHealthCheckGracePeriodSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamRole")]
        public virtual void ResetIamRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchType")]
        public virtual void ResetLaunchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancer")]
        public virtual void ResetLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderedPlacementStrategy")]
        public virtual void ResetOrderedPlacementStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraints")]
        public virtual void ResetPlacementConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementStrategy")]
        public virtual void ResetPlacementStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformVersion")]
        public virtual void ResetPlatformVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagateTags")]
        public virtual void ResetPropagateTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulingStrategy")]
        public virtual void ResetSchedulingStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRegistries")]
        public virtual void ResetServiceRegistries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskDefinition")]
        public virtual void ResetTaskDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServiceCapacityProviderStrategy[]? CapacityProviderStrategyInput
        {
            get => GetInstanceProperty<aws.IEcsServiceCapacityProviderStrategy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentControllerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceDeploymentController\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServiceDeploymentController[]? DeploymentControllerInput
        {
            get => GetInstanceProperty<aws.IEcsServiceDeploymentController[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMaximumPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeploymentMaximumPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMinimumHealthyPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeploymentMinimumHealthyPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTagsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnableEcsManagedTagsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceNewDeploymentInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ForceNewDeploymentInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckGracePeriodSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServiceLoadBalancer[]? LoadBalancerInput
        {
            get => GetInstanceProperty<aws.IEcsServiceLoadBalancer[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServiceNetworkConfiguration[]? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.IEcsServiceNetworkConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderedPlacementStrategyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServiceOrderedPlacementStrategy[]? OrderedPlacementStrategyInput
        {
            get => GetInstanceProperty<aws.IEcsServiceOrderedPlacementStrategy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServicePlacementConstraints[]? PlacementConstraintsInput
        {
            get => GetInstanceProperty<aws.IEcsServicePlacementConstraints[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementStrategyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServicePlacementStrategy[]? PlacementStrategyInput
        {
            get => GetInstanceProperty<aws.IEcsServicePlacementStrategy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagateTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropagateTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulingStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistriesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceServiceRegistries\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEcsServiceServiceRegistries[]? ServiceRegistriesInput
        {
            get => GetInstanceProperty<aws.IEcsServiceServiceRegistries[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.EcsServiceTimeouts\"}", isOptional: true)]
        public virtual aws.IEcsServiceTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IEcsServiceTimeouts?>();
        }

        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServiceCapacityProviderStrategy[] CapacityProviderStrategy
        {
            get => GetInstanceProperty<aws.IEcsServiceCapacityProviderStrategy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cluster
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentController", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceDeploymentController\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServiceDeploymentController[] DeploymentController
        {
            get => GetInstanceProperty<aws.IEcsServiceDeploymentController[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeploymentMaximumPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeploymentMinimumHealthyPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnableEcsManagedTags
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ForceNewDeployment
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServiceLoadBalancer[] LoadBalancer
        {
            get => GetInstanceProperty<aws.IEcsServiceLoadBalancer[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceNetworkConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServiceNetworkConfiguration[] NetworkConfiguration
        {
            get => GetInstanceProperty<aws.IEcsServiceNetworkConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServiceOrderedPlacementStrategy[] OrderedPlacementStrategy
        {
            get => GetInstanceProperty<aws.IEcsServiceOrderedPlacementStrategy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServicePlacementConstraints[] PlacementConstraints
        {
            get => GetInstanceProperty<aws.IEcsServicePlacementConstraints[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServicePlacementStrategy[] PlacementStrategy
        {
            get => GetInstanceProperty<aws.IEcsServicePlacementStrategy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagateTags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EcsServiceServiceRegistries\"},\"kind\":\"array\"}}")]
        public virtual aws.IEcsServiceServiceRegistries[] ServiceRegistries
        {
            get => GetInstanceProperty<aws.IEcsServiceServiceRegistries[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EcsServiceTimeouts\"}")]
        public virtual aws.IEcsServiceTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IEcsServiceTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup), fullyQualifiedName: "aws.AutoscalingGroup", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AutoscalingGroupConfig\"}}]")]
    public class AutoscalingGroup : HashiCorp.Cdktf.TerraformResource
    {
        public AutoscalingGroup(Constructs.Construct scope, string id, aws.IAutoscalingGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAvailabilityZones")]
        public virtual void ResetAvailabilityZones()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultCooldown")]
        public virtual void ResetDefaultCooldown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredCapacity")]
        public virtual void ResetDesiredCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledMetrics")]
        public virtual void ResetEnabledMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDelete")]
        public virtual void ResetForceDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckGracePeriod")]
        public virtual void ResetHealthCheckGracePeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckType")]
        public virtual void ResetHealthCheckType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialLifecycleHook")]
        public virtual void ResetInitialLifecycleHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchConfiguration")]
        public virtual void ResetLaunchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplate")]
        public virtual void ResetLaunchTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancers")]
        public virtual void ResetLoadBalancers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxInstanceLifetime")]
        public virtual void ResetMaxInstanceLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricsGranularity")]
        public virtual void ResetMetricsGranularity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinElbCapacity")]
        public virtual void ResetMinElbCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMixedInstancesPolicy")]
        public virtual void ResetMixedInstancesPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementGroup")]
        public virtual void ResetPlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectFromScaleIn")]
        public virtual void ResetProtectFromScaleIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceLinkedRoleArn")]
        public virtual void ResetServiceLinkedRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuspendedProcesses")]
        public virtual void ResetSuspendedProcesses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGroupArns")]
        public virtual void ResetTargetGroupArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminationPolicies")]
        public virtual void ResetTerminationPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcZoneIdentifier")]
        public virtual void ResetVpcZoneIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForCapacityTimeout")]
        public virtual void ResetWaitForCapacityTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForElbCapacity")]
        public virtual void ResetWaitForElbCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSizeInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSizeInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSizeInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AvailabilityZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultCooldownInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultCooldownInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledMetricsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledMetricsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDeleteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ForceDeleteInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckGracePeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialLifecycleHookInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAutoscalingGroupInitialLifecycleHook[]? InitialLifecycleHookInput
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupInitialLifecycleHook[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupLaunchTemplate\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAutoscalingGroupLaunchTemplate[]? LaunchTemplateInput
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupLaunchTemplate[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LoadBalancersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxInstanceLifetimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxInstanceLifetimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsGranularityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricsGranularityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minElbCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinElbCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mixedInstancesPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAutoscalingGroupMixedInstancesPolicy[]? MixedInstancesPolicyInput
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupMixedInstancesPolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlacementGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectFromScaleInInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ProtectFromScaleInInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLinkedRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceLinkedRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "suspendedProcessesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SuspendedProcessesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupTag\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAutoscalingGroupTag[]? TagInput
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupTag[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetGroupArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationPoliciesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TerminationPoliciesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.AutoscalingGroupTimeouts\"}", isOptional: true)]
        public virtual aws.IAutoscalingGroupTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcZoneIdentifierInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcZoneIdentifierInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForCapacityTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WaitForCapacityTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForElbCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitForElbCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCooldown
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledMetrics
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ForceDelete
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialLifecycleHook", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupInitialLifecycleHook\"},\"kind\":\"array\"}}")]
        public virtual aws.IAutoscalingGroupInitialLifecycleHook[] InitialLifecycleHook
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupInitialLifecycleHook[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupLaunchTemplate\"},\"kind\":\"array\"}}")]
        public virtual aws.IAutoscalingGroupLaunchTemplate[] LaunchTemplate
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupLaunchTemplate[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInstanceLifetime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricsGranularity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricsGranularity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minElbCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinElbCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupMixedInstancesPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IAutoscalingGroupMixedInstancesPolicy[] MixedInstancesPolicy
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupMixedInstancesPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectFromScaleIn", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ProtectFromScaleIn
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLinkedRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SuspendedProcesses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tag", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AutoscalingGroupTag\"},\"kind\":\"array\"}}")]
        public virtual aws.IAutoscalingGroupTag[] Tag
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupTag[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TerminationPolicies
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AutoscalingGroupTimeouts\"}")]
        public virtual aws.IAutoscalingGroupTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IAutoscalingGroupTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcZoneIdentifier
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForCapacityTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WaitForCapacityTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForElbCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitForElbCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}

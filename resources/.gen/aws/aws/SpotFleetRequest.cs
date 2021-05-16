using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SpotFleetRequest), fullyQualifiedName: "aws.SpotFleetRequest", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SpotFleetRequestConfig\"}}]")]
    public class SpotFleetRequest : HashiCorp.Cdktf.TerraformResource
    {
        public SpotFleetRequest(Constructs.Construct scope, string id, aws.ISpotFleetRequestConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotFleetRequest(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotFleetRequest(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllocationStrategy")]
        public virtual void ResetAllocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcessCapacityTerminationPolicy")]
        public virtual void ResetExcessCapacityTerminationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleetType")]
        public virtual void ResetFleetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInterruptionBehaviour")]
        public virtual void ResetInstanceInterruptionBehaviour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstancePoolsToUseCount")]
        public virtual void ResetInstancePoolsToUseCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchSpecification")]
        public virtual void ResetLaunchSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplateConfig")]
        public virtual void ResetLaunchTemplateConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancers")]
        public virtual void ResetLoadBalancers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplaceUnhealthyInstances")]
        public virtual void ResetReplaceUnhealthyInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotPrice")]
        public virtual void ResetSpotPrice()
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

        [JsiiMethod(name: "resetTerminateInstancesWithExpiration")]
        public virtual void ResetTerminateInstancesWithExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidFrom")]
        public virtual void ResetValidFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidUntil")]
        public virtual void ResetValidUntil()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForFulfillment")]
        public virtual void ResetWaitForFulfillment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "clientToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iamFleetRoleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamFleetRoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spotRequestState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotRequestState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetCapacityInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCapacityInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excessCapacityTerminationPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcessCapacityTerminationPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehaviourInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInterruptionBehaviourInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancePoolsToUseCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstancePoolsToUseCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchSpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotFleetRequestLaunchSpecification[]? LaunchSpecificationInput
        {
            get => GetInstanceProperty<aws.ISpotFleetRequestLaunchSpecification[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ISpotFleetRequestLaunchTemplateConfig[]? LaunchTemplateConfigInput
        {
            get => GetInstanceProperty<aws.ISpotFleetRequestLaunchTemplateConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LoadBalancersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceUnhealthyInstancesInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ReplaceUnhealthyInstancesInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotPriceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotPriceInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "terminateInstancesWithExpirationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? TerminateInstancesWithExpirationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.SpotFleetRequestTimeouts\"}", isOptional: true)]
        public virtual aws.ISpotFleetRequestTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.ISpotFleetRequestTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validFromInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValidFromInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validUntilInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValidUntilInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForFulfillmentInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? WaitForFulfillmentInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcessCapacityTerminationPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamFleetRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamFleetRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInterruptionBehaviour
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instancePoolsToUseCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstancePoolsToUseCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchSpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotFleetRequestLaunchSpecification[] LaunchSpecification
        {
            get => GetInstanceProperty<aws.ISpotFleetRequestLaunchSpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SpotFleetRequestLaunchTemplateConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ISpotFleetRequestLaunchTemplateConfig[] LaunchTemplateConfig
        {
            get => GetInstanceProperty<aws.ISpotFleetRequestLaunchTemplateConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ReplaceUnhealthyInstances
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotPrice
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool TerminateInstancesWithExpiration
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.SpotFleetRequestTimeouts\"}")]
        public virtual aws.ISpotFleetRequestTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.ISpotFleetRequestTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidFrom
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidUntil
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool WaitForFulfillment
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}

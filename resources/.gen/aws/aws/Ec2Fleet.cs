using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.Ec2Fleet), fullyQualifiedName: "aws.Ec2Fleet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.Ec2FleetConfig\"}}]")]
    public class Ec2Fleet : HashiCorp.Cdktf.TerraformResource
    {
        public Ec2Fleet(Constructs.Construct scope, string id, aws.IEc2FleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2Fleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2Fleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExcessCapacityTerminationPolicy")]
        public virtual void ResetExcessCapacityTerminationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandOptions")]
        public virtual void ResetOnDemandOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplaceUnhealthyInstances")]
        public virtual void ResetReplaceUnhealthyInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotOptions")]
        public virtual void ResetSpotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateInstances")]
        public virtual void ResetTerminateInstances()
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

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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

        [JsiiProperty(name: "launchTemplateConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2FleetLaunchTemplateConfig[] LaunchTemplateConfigInput
        {
            get => GetInstanceProperty<aws.IEc2FleetLaunchTemplateConfig[]>()!;
        }

        [JsiiProperty(name: "targetCapacitySpecificationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetTargetCapacitySpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2FleetTargetCapacitySpecification[] TargetCapacitySpecificationInput
        {
            get => GetInstanceProperty<aws.IEc2FleetTargetCapacitySpecification[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "excessCapacityTerminationPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcessCapacityTerminationPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetOnDemandOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEc2FleetOnDemandOptions[]? OnDemandOptionsInput
        {
            get => GetInstanceProperty<aws.IEc2FleetOnDemandOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replaceUnhealthyInstancesInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ReplaceUnhealthyInstancesInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetSpotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEc2FleetSpotOptions[]? SpotOptionsInput
        {
            get => GetInstanceProperty<aws.IEc2FleetSpotOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateInstancesInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? TerminateInstancesInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateInstancesWithExpirationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? TerminateInstancesWithExpirationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.Ec2FleetTimeouts\"}", isOptional: true)]
        public virtual aws.IEc2FleetTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IEc2FleetTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcessCapacityTerminationPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2FleetLaunchTemplateConfig[] LaunchTemplateConfig
        {
            get => GetInstanceProperty<aws.IEc2FleetLaunchTemplateConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onDemandOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetOnDemandOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2FleetOnDemandOptions[] OnDemandOptions
        {
            get => GetInstanceProperty<aws.IEc2FleetOnDemandOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ReplaceUnhealthyInstances
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetSpotOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2FleetSpotOptions[] SpotOptions
        {
            get => GetInstanceProperty<aws.IEc2FleetSpotOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetTargetCapacitySpecification\"},\"kind\":\"array\"}}")]
        public virtual aws.IEc2FleetTargetCapacitySpecification[] TargetCapacitySpecification
        {
            get => GetInstanceProperty<aws.IEc2FleetTargetCapacitySpecification[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateInstances", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool TerminateInstances
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool TerminateInstancesWithExpiration
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.Ec2FleetTimeouts\"}")]
        public virtual aws.IEc2FleetTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IEc2FleetTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

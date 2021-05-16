using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GameliftFleet), fullyQualifiedName: "aws.GameliftFleet", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GameliftFleetConfig\"}}]")]
    public class GameliftFleet : HashiCorp.Cdktf.TerraformResource
    {
        public GameliftFleet(Constructs.Construct scope, string id, aws.IGameliftFleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftFleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2InboundPermission")]
        public virtual void ResetEc2InboundPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleetType")]
        public virtual void ResetFleetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceRoleArn")]
        public virtual void ResetInstanceRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricGroups")]
        public virtual void ResetMetricGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNewGameSessionProtectionPolicy")]
        public virtual void ResetNewGameSessionProtectionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceCreationLimitPolicy")]
        public virtual void ResetResourceCreationLimitPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeConfiguration")]
        public virtual void ResetRuntimeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ec2InstanceTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogPaths
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InboundPermissionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGameliftFleetEc2InboundPermission[]? Ec2InboundPermissionInput
        {
            get => GetInstanceProperty<aws.IGameliftFleetEc2InboundPermission[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MetricGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionProtectionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NewGameSessionProtectionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceCreationLimitPolicyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetResourceCreationLimitPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGameliftFleetResourceCreationLimitPolicy[]? ResourceCreationLimitPolicyInput
        {
            get => GetInstanceProperty<aws.IGameliftFleetResourceCreationLimitPolicy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGameliftFleetRuntimeConfiguration[]? RuntimeConfigurationInput
        {
            get => GetInstanceProperty<aws.IGameliftFleetRuntimeConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.GameliftFleetTimeouts\"}", isOptional: true)]
        public virtual aws.IGameliftFleetTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IGameliftFleetTimeouts?>();
        }

        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}")]
        public virtual aws.IGameliftFleetEc2InboundPermission[] Ec2InboundPermission
        {
            get => GetInstanceProperty<aws.IGameliftFleetEc2InboundPermission[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceType
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

        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MetricGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewGameSessionProtectionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetResourceCreationLimitPolicy\"},\"kind\":\"array\"}}")]
        public virtual aws.IGameliftFleetResourceCreationLimitPolicy[] ResourceCreationLimitPolicy
        {
            get => GetInstanceProperty<aws.IGameliftFleetResourceCreationLimitPolicy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.IGameliftFleetRuntimeConfiguration[] RuntimeConfiguration
        {
            get => GetInstanceProperty<aws.IGameliftFleetRuntimeConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.GameliftFleetTimeouts\"}")]
        public virtual aws.IGameliftFleetTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IGameliftFleetTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}

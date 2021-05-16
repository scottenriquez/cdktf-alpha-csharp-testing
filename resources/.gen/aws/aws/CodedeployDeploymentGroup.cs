using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentGroup), fullyQualifiedName: "aws.CodedeployDeploymentGroup", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CodedeployDeploymentGroupConfig\"}}]")]
    public class CodedeployDeploymentGroup : HashiCorp.Cdktf.TerraformResource
    {
        public CodedeployDeploymentGroup(Constructs.Construct scope, string id, aws.ICodedeployDeploymentGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAlarmConfiguration")]
        public virtual void ResetAlarmConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoRollbackConfiguration")]
        public virtual void ResetAutoRollbackConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingGroups")]
        public virtual void ResetAutoscalingGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlueGreenDeploymentConfig")]
        public virtual void ResetBlueGreenDeploymentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentConfigName")]
        public virtual void ResetDeploymentConfigName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentStyle")]
        public virtual void ResetDeploymentStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2TagFilter")]
        public virtual void ResetEc2TagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2TagSet")]
        public virtual void ResetEc2TagSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsService")]
        public virtual void ResetEcsService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerInfo")]
        public virtual void ResetLoadBalancerInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnPremisesInstanceTagFilter")]
        public virtual void ResetOnPremisesInstanceTagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerConfiguration")]
        public virtual void ResetTriggerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "appNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentGroupNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentGroupNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAlarmConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupAlarmConfiguration[]? AlarmConfigurationInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupAlarmConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAutoRollbackConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]? AutoRollbackConfigurationInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AutoscalingGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueGreenDeploymentConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]? BlueGreenDeploymentConfigInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentConfigNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentStyleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupDeploymentStyle\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupDeploymentStyle[]? DeploymentStyleInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupDeploymentStyle[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2TagFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupEc2TagFilter[]? Ec2TagFilterInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2TagSetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupEc2TagSet[]? Ec2TagSetInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagSet[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsServiceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEcsService\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupEcsService[]? EcsServiceInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEcsService[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupLoadBalancerInfo[]? LoadBalancerInfoInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfo[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPremisesInstanceTagFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]? OnPremisesInstanceTagFilterInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICodedeployDeploymentGroupTriggerConfiguration[]? TriggerConfigurationInput
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupTriggerConfiguration[]?>();
        }

        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAlarmConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupAlarmConfiguration[] AlarmConfiguration
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupAlarmConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAutoRollbackConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[] AutoRollbackConfiguration
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoscalingGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[] BlueGreenDeploymentConfig
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupDeploymentStyle\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupDeploymentStyle[] DeploymentStyle
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupDeploymentStyle[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupEc2TagFilter[] Ec2TagFilter
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupEc2TagSet[] Ec2TagSet
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagSet[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ecsService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEcsService\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupEcsService[] EcsService
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEcsService[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupLoadBalancerInfo[] LoadBalancerInfo
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfo[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[] OnPremisesInstanceTagFilter
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.ICodedeployDeploymentGroupTriggerConfiguration[] TriggerConfiguration
        {
            get => GetInstanceProperty<aws.ICodedeployDeploymentGroupTriggerConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}

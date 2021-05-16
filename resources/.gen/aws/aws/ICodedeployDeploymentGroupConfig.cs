using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupConfig), fullyQualifiedName: "aws.CodedeployDeploymentGroupConfig")]
    public interface ICodedeployDeploymentGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        string AppName
        {
            get;
        }

        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentGroupName
        {
            get;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRoleArn
        {
            get;
        }

        /// <summary>alarm_configuration block.</summary>
        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAlarmConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupAlarmConfiguration[]? AlarmConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_rollback_configuration block.</summary>
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAutoRollbackConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]? AutoRollbackConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AutoscalingGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>blue_green_deployment_config block.</summary>
        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]? BlueGreenDeploymentConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentConfigName
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment_style block.</summary>
        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupDeploymentStyle\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupDeploymentStyle[]? DeploymentStyle
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_tag_filter block.</summary>
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupEc2TagFilter[]? Ec2TagFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_tag_set block.</summary>
        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupEc2TagSet[]? Ec2TagSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_service block.</summary>
        [JsiiProperty(name: "ecsService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEcsService\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupEcsService[]? EcsService
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer_info block.</summary>
        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupLoadBalancerInfo[]? LoadBalancerInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_premises_instance_tag_filter block.</summary>
        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]? OnPremisesInstanceTagFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger_configuration block.</summary>
        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodedeployDeploymentGroupTriggerConfiguration[]? TriggerConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupConfig), fullyQualifiedName: "aws.CodedeployDeploymentGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
            public string AppName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alarm_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAlarmConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupAlarmConfiguration[]? AlarmConfiguration
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupAlarmConfiguration[]?>();
            }

            /// <summary>auto_rollback_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAutoRollbackConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]? AutoRollbackConfiguration
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AutoscalingGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>blue_green_deployment_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]? BlueGreenDeploymentConfig
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentConfigName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deployment_style block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentStyle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupDeploymentStyle\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupDeploymentStyle[]? DeploymentStyle
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupDeploymentStyle[]?>();
            }

            /// <summary>ec2_tag_filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupEc2TagFilter[]? Ec2TagFilter
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagFilter[]?>();
            }

            /// <summary>ec2_tag_set block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagSet", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupEc2TagSet[]? Ec2TagSet
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEc2TagSet[]?>();
            }

            /// <summary>ecs_service block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ecsService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEcsService\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupEcsService[]? EcsService
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupEcsService[]?>();
            }

            /// <summary>load_balancer_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupLoadBalancerInfo[]? LoadBalancerInfo
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupLoadBalancerInfo[]?>();
            }

            /// <summary>on_premises_instance_tag_filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]? OnPremisesInstanceTagFilter
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]?>();
            }

            /// <summary>trigger_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodedeployDeploymentGroupTriggerConfiguration[]? TriggerConfiguration
            {
                get => GetInstanceProperty<aws.ICodedeployDeploymentGroupTriggerConfiguration[]?>();
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

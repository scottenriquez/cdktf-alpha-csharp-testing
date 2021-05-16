using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodedeployDeploymentGroupConfig")]
    public class CodedeployDeploymentGroupConfig : aws.ICodedeployDeploymentGroupConfig
    {
        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AppName
        {
            get;
            set;
        }

        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DeploymentGroupName
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRoleArn
        {
            get;
            set;
        }

        /// <summary>alarm_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAlarmConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupAlarmConfiguration[]? AlarmConfiguration
        {
            get;
            set;
        }

        /// <summary>auto_rollback_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupAutoRollbackConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupAutoRollbackConfiguration[]? AutoRollbackConfiguration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AutoscalingGroups
        {
            get;
            set;
        }

        /// <summary>blue_green_deployment_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupBlueGreenDeploymentConfig[]? BlueGreenDeploymentConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeploymentConfigName
        {
            get;
            set;
        }

        /// <summary>deployment_style block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupDeploymentStyle\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupDeploymentStyle[]? DeploymentStyle
        {
            get;
            set;
        }

        /// <summary>ec2_tag_filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupEc2TagFilter[]? Ec2TagFilter
        {
            get;
            set;
        }

        /// <summary>ec2_tag_set block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupEc2TagSet[]? Ec2TagSet
        {
            get;
            set;
        }

        /// <summary>ecs_service block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ecsService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupEcsService\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupEcsService[]? EcsService
        {
            get;
            set;
        }

        /// <summary>load_balancer_info block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupLoadBalancerInfo\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupLoadBalancerInfo[]? LoadBalancerInfo
        {
            get;
            set;
        }

        /// <summary>on_premises_instance_tag_filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter[]? OnPremisesInstanceTagFilter
        {
            get;
            set;
        }

        /// <summary>trigger_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodedeployDeploymentGroupTriggerConfiguration[]? TriggerConfiguration
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GameliftFleetConfig")]
    public class GameliftFleetConfig : aws.IGameliftFleetConfig
    {
        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BuildId
        {
            get;
            set;
        }

        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Ec2InstanceType
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>ec2_inbound_permission block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGameliftFleetEc2InboundPermission[]? Ec2InboundPermission
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FleetType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? MetricGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NewGameSessionProtectionPolicy
        {
            get;
            set;
        }

        /// <summary>resource_creation_limit_policy block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetResourceCreationLimitPolicy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGameliftFleetResourceCreationLimitPolicy[]? ResourceCreationLimitPolicy
        {
            get;
            set;
        }

        /// <summary>runtime_configuration block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfiguration\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IGameliftFleetRuntimeConfiguration[]? RuntimeConfiguration
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

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.GameliftFleetTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IGameliftFleetTimeouts? Timeouts
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

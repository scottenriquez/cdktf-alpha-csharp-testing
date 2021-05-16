using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEc2FleetConfig), fullyQualifiedName: "aws.Ec2FleetConfig")]
    public interface IEc2FleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>launch_template_config block.</summary>
        [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfig\"},\"kind\":\"array\"}}")]
        aws.IEc2FleetLaunchTemplateConfig[] LaunchTemplateConfig
        {
            get;
        }

        /// <summary>target_capacity_specification block.</summary>
        [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetTargetCapacitySpecification\"},\"kind\":\"array\"}}")]
        aws.IEc2FleetTargetCapacitySpecification[] TargetCapacitySpecification
        {
            get;
        }

        [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcessCapacityTerminationPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_demand_options block.</summary>
        [JsiiProperty(name: "onDemandOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetOnDemandOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEc2FleetOnDemandOptions[]? OnDemandOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReplaceUnhealthyInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_options block.</summary>
        [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetSpotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEc2FleetSpotOptions[]? SpotOptions
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

        [JsiiProperty(name: "terminateInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? TerminateInstances
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? TerminateInstancesWithExpiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.Ec2FleetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEc2FleetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetConfig), fullyQualifiedName: "aws.Ec2FleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEc2FleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_config block.</summary>
            [JsiiProperty(name: "launchTemplateConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetLaunchTemplateConfig\"},\"kind\":\"array\"}}")]
            public aws.IEc2FleetLaunchTemplateConfig[] LaunchTemplateConfig
            {
                get => GetInstanceProperty<aws.IEc2FleetLaunchTemplateConfig[]>()!;
            }

            /// <summary>target_capacity_specification block.</summary>
            [JsiiProperty(name: "targetCapacitySpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetTargetCapacitySpecification\"},\"kind\":\"array\"}}")]
            public aws.IEc2FleetTargetCapacitySpecification[] TargetCapacitySpecification
            {
                get => GetInstanceProperty<aws.IEc2FleetTargetCapacitySpecification[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "excessCapacityTerminationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcessCapacityTerminationPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>on_demand_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetOnDemandOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEc2FleetOnDemandOptions[]? OnDemandOptions
            {
                get => GetInstanceProperty<aws.IEc2FleetOnDemandOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "replaceUnhealthyInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReplaceUnhealthyInstances
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>spot_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Ec2FleetSpotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEc2FleetSpotOptions[]? SpotOptions
            {
                get => GetInstanceProperty<aws.IEc2FleetSpotOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "terminateInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? TerminateInstances
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "terminateInstancesWithExpiration", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? TerminateInstancesWithExpiration
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.Ec2FleetTimeouts\"}", isOptional: true)]
            public aws.IEc2FleetTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IEc2FleetTimeouts?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
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

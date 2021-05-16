using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetConfig), fullyQualifiedName: "aws.GameliftFleetConfig")]
    public interface IGameliftFleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
        string BuildId
        {
            get;
        }

        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string Ec2InstanceType
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_inbound_permission block.</summary>
        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGameliftFleetEc2InboundPermission[]? Ec2InboundPermission
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MetricGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NewGameSessionProtectionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_creation_limit_policy block.</summary>
        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetResourceCreationLimitPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGameliftFleetResourceCreationLimitPolicy[]? ResourceCreationLimitPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>runtime_configuration block.</summary>
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGameliftFleetRuntimeConfiguration[]? RuntimeConfiguration
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

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.GameliftFleetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGameliftFleetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetConfig), fullyQualifiedName: "aws.GameliftFleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IGameliftFleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string Ec2InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ec2_inbound_permission block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGameliftFleetEc2InboundPermission[]? Ec2InboundPermission
            {
                get => GetInstanceProperty<aws.IGameliftFleetEc2InboundPermission[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MetricGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NewGameSessionProtectionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>resource_creation_limit_policy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetResourceCreationLimitPolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGameliftFleetResourceCreationLimitPolicy[]? ResourceCreationLimitPolicy
            {
                get => GetInstanceProperty<aws.IGameliftFleetResourceCreationLimitPolicy[]?>();
            }

            /// <summary>runtime_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGameliftFleetRuntimeConfiguration[]? RuntimeConfiguration
            {
                get => GetInstanceProperty<aws.IGameliftFleetRuntimeConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.GameliftFleetTimeouts\"}", isOptional: true)]
            public aws.IGameliftFleetTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IGameliftFleetTimeouts?>();
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

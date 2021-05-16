using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMqBrokerConfig), fullyQualifiedName: "aws.MqBrokerConfig")]
    public interface IMqBrokerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        string BrokerName
        {
            get;
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        string EngineType
        {
            get;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        string EngineVersion
        {
            get;
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string HostInstanceType
        {
            get;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroups
        {
            get;
        }

        /// <summary>user block.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerUser\"},\"kind\":\"array\"}}")]
        aws.IMqBrokerUser[] User
        {
            get;
        }

        [JsiiProperty(name: "applyImmediately", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ApplyImmediately
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoMinorVersionUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration block.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMqBrokerConfiguration[]? Configuration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_options block.</summary>
        [JsiiProperty(name: "encryptionOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerEncryptionOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMqBrokerEncryptionOptions[]? EncryptionOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs block.</summary>
        [JsiiProperty(name: "logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerLogs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMqBrokerLogs[]? Logs
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window_start_time block.</summary>
        [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerMaintenanceWindowStartTime\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMqBrokerMaintenanceWindowStartTime[]? MaintenanceWindowStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? PubliclyAccessible
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
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

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerConfig), fullyQualifiedName: "aws.MqBrokerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IMqBrokerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
            public string BrokerName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
            public string EngineType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string EngineVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string HostInstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroups
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>user block.</summary>
            [JsiiProperty(name: "user", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerUser\"},\"kind\":\"array\"}}")]
            public aws.IMqBrokerUser[] User
            {
                get => GetInstanceProperty<aws.IMqBrokerUser[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "applyImmediately", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ApplyImmediately
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoMinorVersionUpgrade
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMqBrokerConfiguration[]? Configuration
            {
                get => GetInstanceProperty<aws.IMqBrokerConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerEncryptionOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMqBrokerEncryptionOptions[]? EncryptionOptions
            {
                get => GetInstanceProperty<aws.IMqBrokerEncryptionOptions[]?>();
            }

            /// <summary>logs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerLogs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMqBrokerLogs[]? Logs
            {
                get => GetInstanceProperty<aws.IMqBrokerLogs[]?>();
            }

            /// <summary>maintenance_window_start_time block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowStartTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MqBrokerMaintenanceWindowStartTime\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMqBrokerMaintenanceWindowStartTime[]? MaintenanceWindowStartTime
            {
                get => GetInstanceProperty<aws.IMqBrokerMaintenanceWindowStartTime[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? PubliclyAccessible
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlueJobConfig), fullyQualifiedName: "aws.GlueJobConfig")]
    public interface IGlueJobConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>command block.</summary>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobCommand\"},\"kind\":\"array\"}}")]
        aws.IGlueJobCommand[] Command
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllocatedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Connections
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefaultArguments
        {
            get
            {
                return null;
            }
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

        /// <summary>execution_property block.</summary>
        [JsiiProperty(name: "executionProperty", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobExecutionProperty\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueJobExecutionProperty[]? ExecutionProperty
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GlueVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification_property block.</summary>
        [JsiiProperty(name: "notificationProperty", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobNotificationProperty\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGlueJobNotificationProperty[]? NotificationProperty
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfWorkers
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityConfiguration
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

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkerType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobConfig), fullyQualifiedName: "aws.GlueJobConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IGlueJobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>command block.</summary>
            [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobCommand\"},\"kind\":\"array\"}}")]
            public aws.IGlueJobCommand[] Command
            {
                get => GetInstanceProperty<aws.IGlueJobCommand[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllocatedCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Connections
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefaultArguments
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>execution_property block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionProperty", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobExecutionProperty\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueJobExecutionProperty[]? ExecutionProperty
            {
                get => GetInstanceProperty<aws.IGlueJobExecutionProperty[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GlueVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>notification_property block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationProperty", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueJobNotificationProperty\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGlueJobNotificationProperty[]? NotificationProperty
            {
                get => GetInstanceProperty<aws.IGlueJobNotificationProperty[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfWorkers
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkerType
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

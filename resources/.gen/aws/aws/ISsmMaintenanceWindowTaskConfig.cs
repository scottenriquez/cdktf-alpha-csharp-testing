using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskConfig), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskConfig")]
    public interface ISsmMaintenanceWindowTaskConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}")]
        string MaxConcurrency
        {
            get;
        }

        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}")]
        string MaxErrors
        {
            get;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRoleArn
        {
            get;
        }

        /// <summary>targets block.</summary>
        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}")]
        aws.ISsmMaintenanceWindowTaskTargets[] Targets
        {
            get;
        }

        [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
        string TaskArn
        {
            get;
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        string TaskType
        {
            get;
        }

        [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
        string WindowId
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

        /// <summary>logging_info block.</summary>
        [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskLoggingInfo[]? LoggingInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>task_invocation_parameters block.</summary>
        [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]? TaskInvocationParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>task_parameters block.</summary>
        [JsiiProperty(name: "taskParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskParameters[]? TaskParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskConfig), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}")]
            public string MaxConcurrency
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}")]
            public string MaxErrors
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>targets block.</summary>
            [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}")]
            public aws.ISsmMaintenanceWindowTaskTargets[] Targets
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTargets[]>()!;
            }

            [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
            public string WindowId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logging_info block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loggingInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskLoggingInfo\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskLoggingInfo[]? LoggingInfo
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskLoggingInfo[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>task_invocation_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]? TaskInvocationParameters
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParameters[]?>();
            }

            /// <summary>task_parameters block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskParameters[]? TaskParameters
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskParameters[]?>();
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

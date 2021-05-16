using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters
    {
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "documentHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentHash
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "documentHashType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentHashType
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification_config block.</summary>
        [JsiiProperty(name: "notificationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig[]? NotificationConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "outputS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputS3Bucket
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "outputS3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputS3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameter block.</summary>
        [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter[]? Parameter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "documentHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentHash
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "documentHashType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentHashType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>notification_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig[]? NotificationConfig
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "outputS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputS3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "outputS3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputS3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parameter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter[]? Parameter
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

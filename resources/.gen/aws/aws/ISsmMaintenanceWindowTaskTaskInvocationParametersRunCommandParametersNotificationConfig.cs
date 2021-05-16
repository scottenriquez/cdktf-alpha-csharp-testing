using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig
    {
        [JsiiProperty(name: "notificationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "notificationEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotificationEvents
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "notificationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "notificationEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotificationEvents
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

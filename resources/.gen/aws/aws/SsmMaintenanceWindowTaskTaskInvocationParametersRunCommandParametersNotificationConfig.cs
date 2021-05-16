using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig : aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "notificationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotificationArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? NotificationEvents
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotificationType
        {
            get;
            set;
        }
    }
}

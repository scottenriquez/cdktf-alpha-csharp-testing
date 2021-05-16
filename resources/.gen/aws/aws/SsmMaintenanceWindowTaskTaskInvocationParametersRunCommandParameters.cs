using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters : aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters
    {
        [JsiiOptional]
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Comment
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DocumentHash
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentHashType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DocumentHashType
        {
            get;
            set;
        }

        /// <summary>notification_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersNotificationConfig[]? NotificationConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OutputS3Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputS3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OutputS3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>parameter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter[]? Parameter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}

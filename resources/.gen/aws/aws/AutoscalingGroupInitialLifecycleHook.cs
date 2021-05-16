using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AutoscalingGroupInitialLifecycleHook")]
    public class AutoscalingGroupInitialLifecycleHook : aws.IAutoscalingGroupInitialLifecycleHook
    {
        [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LifecycleTransition
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
        [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultResult
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HeartbeatTimeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotificationMetadata
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NotificationTargetArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RoleArn
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInitialLifecycleHook), fullyQualifiedName: "aws.AutoscalingGroupInitialLifecycleHook")]
    public interface IAutoscalingGroupInitialLifecycleHook
    {
        [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}")]
        string LifecycleTransition
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultResult
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HeartbeatTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationMetadata
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationTargetArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInitialLifecycleHook), fullyQualifiedName: "aws.AutoscalingGroupInitialLifecycleHook")]
        internal sealed class _Proxy : DeputyBase, aws.IAutoscalingGroupInitialLifecycleHook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}")]
            public string LifecycleTransition
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultResult
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeartbeatTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationMetadata
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationTargetArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

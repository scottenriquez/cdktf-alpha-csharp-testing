using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetEcsTarget), fullyQualifiedName: "aws.CloudwatchEventTargetEcsTarget")]
    public interface ICloudwatchEventTargetEcsTarget
    {
        [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        string TaskDefinitionArn
        {
            get;
        }

        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Group
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_configuration block.</summary>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTargetNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudwatchEventTargetEcsTargetNetworkConfiguration[]? NetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TaskCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetEcsTarget), fullyQualifiedName: "aws.CloudwatchEventTargetEcsTarget")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchEventTargetEcsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskDefinitionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudwatchEventTargetEcsTargetNetworkConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudwatchEventTargetEcsTargetNetworkConfiguration[]? NetworkConfiguration
            {
                get => GetInstanceProperty<aws.ICloudwatchEventTargetEcsTargetNetworkConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TaskCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

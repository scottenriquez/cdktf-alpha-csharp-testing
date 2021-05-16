using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetRuntimeConfigurationServerProcess), fullyQualifiedName: "aws.GameliftFleetRuntimeConfigurationServerProcess")]
    public interface IGameliftFleetRuntimeConfigurationServerProcess
    {
        [JsiiProperty(name: "concurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        double ConcurrentExecutions
        {
            get;
        }

        [JsiiProperty(name: "launchPath", typeJson: "{\"primitive\":\"string\"}")]
        string LaunchPath
        {
            get;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetRuntimeConfigurationServerProcess), fullyQualifiedName: "aws.GameliftFleetRuntimeConfigurationServerProcess")]
        internal sealed class _Proxy : DeputyBase, aws.IGameliftFleetRuntimeConfigurationServerProcess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "concurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
            public double ConcurrentExecutions
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "launchPath", typeJson: "{\"primitive\":\"string\"}")]
            public string LaunchPath
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parameters
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

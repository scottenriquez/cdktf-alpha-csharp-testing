using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfoBrokerLogsCloudwatchLogs), fullyQualifiedName: "aws.MskClusterLoggingInfoBrokerLogsCloudwatchLogs")]
    public interface IMskClusterLoggingInfoBrokerLogsCloudwatchLogs
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfoBrokerLogsCloudwatchLogs), fullyQualifiedName: "aws.MskClusterLoggingInfoBrokerLogsCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

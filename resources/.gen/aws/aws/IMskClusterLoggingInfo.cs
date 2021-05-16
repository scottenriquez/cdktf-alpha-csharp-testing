using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterLoggingInfo), fullyQualifiedName: "aws.MskClusterLoggingInfo")]
    public interface IMskClusterLoggingInfo
    {
        /// <summary>broker_logs block.</summary>
        [JsiiProperty(name: "brokerLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogs\"},\"kind\":\"array\"}}")]
        aws.IMskClusterLoggingInfoBrokerLogs[] BrokerLogs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterLoggingInfo), fullyQualifiedName: "aws.MskClusterLoggingInfo")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterLoggingInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>broker_logs block.</summary>
            [JsiiProperty(name: "brokerLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogs\"},\"kind\":\"array\"}}")]
            public aws.IMskClusterLoggingInfoBrokerLogs[] BrokerLogs
            {
                get => GetInstanceProperty<aws.IMskClusterLoggingInfoBrokerLogs[]>()!;
            }
        }
    }
}

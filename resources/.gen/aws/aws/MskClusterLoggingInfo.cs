using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterLoggingInfo")]
    public class MskClusterLoggingInfo : aws.IMskClusterLoggingInfo
    {
        /// <summary>broker_logs block.</summary>
        [JsiiProperty(name: "brokerLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterLoggingInfoBrokerLogs\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IMskClusterLoggingInfoBrokerLogs[] BrokerLogs
        {
            get;
            set;
        }
    }
}

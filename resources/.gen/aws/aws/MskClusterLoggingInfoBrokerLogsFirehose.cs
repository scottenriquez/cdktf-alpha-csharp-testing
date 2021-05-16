using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterLoggingInfoBrokerLogsFirehose")]
    public class MskClusterLoggingInfoBrokerLogsFirehose : aws.IMskClusterLoggingInfoBrokerLogsFirehose
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeliveryStream
        {
            get;
            set;
        }
    }
}

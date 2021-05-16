using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MqBrokerLogs")]
    public class MqBrokerLogs : aws.IMqBrokerLogs
    {
        [JsiiOptional]
        [JsiiProperty(name: "audit", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Audit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "general", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? General
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DmsEndpointKafkaSettings")]
    public class DmsEndpointKafkaSettings : aws.IDmsEndpointKafkaSettings
    {
        [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Broker
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Topic
        {
            get;
            set;
        }
    }
}

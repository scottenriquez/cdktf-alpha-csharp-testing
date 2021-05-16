using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MqBrokerConfiguration")]
    public class MqBrokerConfiguration : aws.IMqBrokerConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Id
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Revision
        {
            get;
            set;
        }
    }
}

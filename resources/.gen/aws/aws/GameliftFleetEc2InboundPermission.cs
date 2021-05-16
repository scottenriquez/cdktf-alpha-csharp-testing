using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GameliftFleetEc2InboundPermission")]
    public class GameliftFleetEc2InboundPermission : aws.IGameliftFleetEc2InboundPermission
    {
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double FromPort
        {
            get;
            set;
        }

        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IpRange
        {
            get;
            set;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Protocol
        {
            get;
            set;
        }

        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ToPort
        {
            get;
            set;
        }
    }
}

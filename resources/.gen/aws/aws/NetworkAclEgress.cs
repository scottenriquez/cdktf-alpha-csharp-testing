using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.NetworkAclEgress")]
    public class NetworkAclEgress : aws.INetworkAclEgress
    {
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Action
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FromPort
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? IcmpCode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? IcmpType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Ipv6CidrBlock
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Protocol
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleNo", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RuleNo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ToPort
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DefaultNetworkAclEgress")]
    public class DefaultNetworkAclEgress : aws.IDefaultNetworkAclEgress
    {
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Action
        {
            get;
            set;
        }

        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double FromPort
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

        [JsiiProperty(name: "ruleNo", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double RuleNo
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

        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CidrBlock
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
    }
}

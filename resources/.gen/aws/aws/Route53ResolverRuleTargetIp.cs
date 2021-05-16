using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Route53ResolverRuleTargetIp")]
    public class Route53ResolverRuleTargetIp : aws.IRoute53ResolverRuleTargetIp
    {
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Ip
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}

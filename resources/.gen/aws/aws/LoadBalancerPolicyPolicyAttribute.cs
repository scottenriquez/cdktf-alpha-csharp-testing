using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LoadBalancerPolicyPolicyAttribute")]
    public class LoadBalancerPolicyPolicyAttribute : aws.ILoadBalancerPolicyPolicyAttribute
    {
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}

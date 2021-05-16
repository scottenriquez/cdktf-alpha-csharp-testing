using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LbListenerTimeouts")]
    public class LbListenerTimeouts : aws.ILbListenerTimeouts
    {
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlobalacceleratorListenerPortRange")]
    public class GlobalacceleratorListenerPortRange : aws.IGlobalacceleratorListenerPortRange
    {
        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FromPort
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

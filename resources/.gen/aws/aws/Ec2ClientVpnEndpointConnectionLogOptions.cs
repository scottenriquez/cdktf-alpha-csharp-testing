using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2ClientVpnEndpointConnectionLogOptions")]
    public class Ec2ClientVpnEndpointConnectionLogOptions : aws.IEc2ClientVpnEndpointConnectionLogOptions
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudwatchLogGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudwatchLogStream
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Ec2ClientVpnEndpointAuthenticationOptions")]
    public class Ec2ClientVpnEndpointAuthenticationOptions : aws.IEc2ClientVpnEndpointAuthenticationOptions
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ActiveDirectoryId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootCertificateChainArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RootCertificateChainArn
        {
            get;
            set;
        }
    }
}

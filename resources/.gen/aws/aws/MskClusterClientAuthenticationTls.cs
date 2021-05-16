using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MskClusterClientAuthenticationTls")]
    public class MskClusterClientAuthenticationTls : aws.IMskClusterClientAuthenticationTls
    {
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CertificateAuthorityArns
        {
            get;
            set;
        }
    }
}

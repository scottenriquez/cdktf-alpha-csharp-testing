using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.Apigatewayv2DomainNameDomainNameConfiguration")]
    public class Apigatewayv2DomainNameDomainNameConfiguration : aws.IApigatewayv2DomainNameDomainNameConfiguration
    {
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CertificateArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EndpointType
        {
            get;
            set;
        }

        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SecurityPolicy
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayDomainNameEndpointConfiguration")]
    public class ApiGatewayDomainNameEndpointConfiguration : aws.IApiGatewayDomainNameEndpointConfiguration
    {
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Types
        {
            get;
            set;
        }
    }
}

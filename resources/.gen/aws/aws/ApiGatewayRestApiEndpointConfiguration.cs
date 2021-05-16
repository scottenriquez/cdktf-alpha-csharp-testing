using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ApiGatewayRestApiEndpointConfiguration")]
    public class ApiGatewayRestApiEndpointConfiguration : aws.IApiGatewayRestApiEndpointConfiguration
    {
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Types
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcEndpointIds
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlobalacceleratorEndpointGroupEndpointConfiguration")]
    public class GlobalacceleratorEndpointGroupEndpointConfiguration : aws.IGlobalacceleratorEndpointGroupEndpointConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EndpointId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}

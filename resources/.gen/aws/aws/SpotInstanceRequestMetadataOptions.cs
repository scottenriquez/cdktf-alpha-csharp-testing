using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.SpotInstanceRequestMetadataOptions")]
    public class SpotInstanceRequestMetadataOptions : aws.ISpotInstanceRequestMetadataOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HttpEndpoint
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? HttpPutResponseHopLimit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HttpTokens
        {
            get;
            set;
        }
    }
}

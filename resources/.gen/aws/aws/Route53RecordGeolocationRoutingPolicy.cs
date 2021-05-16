using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.Route53RecordGeolocationRoutingPolicy")]
    public class Route53RecordGeolocationRoutingPolicy : aws.IRoute53RecordGeolocationRoutingPolicy
    {
        [JsiiOptional]
        [JsiiProperty(name: "continent", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Continent
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Country
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subdivision", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Subdivision
        {
            get;
            set;
        }
    }
}

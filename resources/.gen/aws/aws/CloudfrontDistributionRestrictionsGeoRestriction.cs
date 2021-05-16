using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionRestrictionsGeoRestriction")]
    public class CloudfrontDistributionRestrictionsGeoRestriction : aws.ICloudfrontDistributionRestrictionsGeoRestriction
    {
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RestrictionType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Locations
        {
            get;
            set;
        }
    }
}

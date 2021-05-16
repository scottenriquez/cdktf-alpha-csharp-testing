using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionRestrictions")]
    public class CloudfrontDistributionRestrictions : aws.ICloudfrontDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictionsGeoRestriction\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionRestrictionsGeoRestriction[] GeoRestriction
        {
            get;
            set;
        }
    }
}

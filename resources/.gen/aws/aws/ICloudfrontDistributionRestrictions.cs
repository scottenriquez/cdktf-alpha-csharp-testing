using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionRestrictions), fullyQualifiedName: "aws.CloudfrontDistributionRestrictions")]
    public interface ICloudfrontDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictionsGeoRestriction\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionRestrictionsGeoRestriction[] GeoRestriction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionRestrictions), fullyQualifiedName: "aws.CloudfrontDistributionRestrictions")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>geo_restriction block.</summary>
            [JsiiProperty(name: "geoRestriction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionRestrictionsGeoRestriction\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionRestrictionsGeoRestriction[] GeoRestriction
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionRestrictionsGeoRestriction[]>()!;
            }
        }
    }
}

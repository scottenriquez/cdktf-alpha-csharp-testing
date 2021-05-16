using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionRestrictionsGeoRestriction), fullyQualifiedName: "aws.CloudfrontDistributionRestrictionsGeoRestriction")]
    public interface ICloudfrontDistributionRestrictionsGeoRestriction
    {
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}")]
        string RestrictionType
        {
            get;
        }

        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Locations
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionRestrictionsGeoRestriction), fullyQualifiedName: "aws.CloudfrontDistributionRestrictionsGeoRestriction")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionRestrictionsGeoRestriction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}")]
            public string RestrictionType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Locations
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

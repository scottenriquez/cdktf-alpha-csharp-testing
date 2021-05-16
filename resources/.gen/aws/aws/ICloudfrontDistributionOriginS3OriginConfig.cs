using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginS3OriginConfig), fullyQualifiedName: "aws.CloudfrontDistributionOriginS3OriginConfig")]
    public interface ICloudfrontDistributionOriginS3OriginConfig
    {
        [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
        string OriginAccessIdentity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginS3OriginConfig), fullyQualifiedName: "aws.CloudfrontDistributionOriginS3OriginConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOriginS3OriginConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginAccessIdentity
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

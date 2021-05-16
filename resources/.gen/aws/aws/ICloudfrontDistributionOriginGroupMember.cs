using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginGroupMember), fullyQualifiedName: "aws.CloudfrontDistributionOriginGroupMember")]
    public interface ICloudfrontDistributionOriginGroupMember
    {
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginGroupMember), fullyQualifiedName: "aws.CloudfrontDistributionOriginGroupMember")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOriginGroupMember
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

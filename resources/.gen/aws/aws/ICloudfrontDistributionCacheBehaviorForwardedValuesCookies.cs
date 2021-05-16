using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionCacheBehaviorForwardedValuesCookies), fullyQualifiedName: "aws.CloudfrontDistributionCacheBehaviorForwardedValuesCookies")]
    public interface ICloudfrontDistributionCacheBehaviorForwardedValuesCookies
    {
        [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}")]
        string Forward
        {
            get;
        }

        [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WhitelistedNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionCacheBehaviorForwardedValuesCookies), fullyQualifiedName: "aws.CloudfrontDistributionCacheBehaviorForwardedValuesCookies")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "forward", typeJson: "{\"primitive\":\"string\"}")]
            public string Forward
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "whitelistedNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WhitelistedNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

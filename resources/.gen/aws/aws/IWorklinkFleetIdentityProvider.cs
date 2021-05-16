using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWorklinkFleetIdentityProvider), fullyQualifiedName: "aws.WorklinkFleetIdentityProvider")]
    public interface IWorklinkFleetIdentityProvider
    {
        [JsiiProperty(name: "samlMetadata", typeJson: "{\"primitive\":\"string\"}")]
        string SamlMetadata
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorklinkFleetIdentityProvider), fullyQualifiedName: "aws.WorklinkFleetIdentityProvider")]
        internal sealed class _Proxy : DeputyBase, aws.IWorklinkFleetIdentityProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "samlMetadata", typeJson: "{\"primitive\":\"string\"}")]
            public string SamlMetadata
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

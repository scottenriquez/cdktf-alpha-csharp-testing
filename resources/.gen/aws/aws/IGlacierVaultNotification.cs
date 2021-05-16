using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGlacierVaultNotification), fullyQualifiedName: "aws.GlacierVaultNotification")]
    public interface IGlacierVaultNotification
    {
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Events
        {
            get;
        }

        [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
        string SnsTopic
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlacierVaultNotification), fullyQualifiedName: "aws.GlacierVaultNotification")]
        internal sealed class _Proxy : DeputyBase, aws.IGlacierVaultNotification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Events
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsTopic
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

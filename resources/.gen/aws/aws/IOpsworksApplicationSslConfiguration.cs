using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksApplicationSslConfiguration), fullyQualifiedName: "aws.OpsworksApplicationSslConfiguration")]
    public interface IOpsworksApplicationSslConfiguration
    {
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        string Certificate
        {
            get;
        }

        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateKey
        {
            get;
        }

        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Chain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksApplicationSslConfiguration), fullyQualifiedName: "aws.OpsworksApplicationSslConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksApplicationSslConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
            public string Certificate
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateKey
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Chain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEksClusterEncryptionConfig), fullyQualifiedName: "aws.EksClusterEncryptionConfig")]
    public interface IEksClusterEncryptionConfig
    {
        /// <summary>provider block.</summary>
        [JsiiProperty(name: "provider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterEncryptionConfigProvider\"},\"kind\":\"array\"}}")]
        aws.IEksClusterEncryptionConfigProvider[] Provider
        {
            get;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterEncryptionConfig), fullyQualifiedName: "aws.EksClusterEncryptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEksClusterEncryptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider block.</summary>
            [JsiiProperty(name: "provider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterEncryptionConfigProvider\"},\"kind\":\"array\"}}")]
            public aws.IEksClusterEncryptionConfigProvider[] Provider
            {
                get => GetInstanceProperty<aws.IEksClusterEncryptionConfigProvider[]>()!;
            }

            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Resources
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

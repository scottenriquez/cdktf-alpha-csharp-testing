using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEksClusterEncryptionConfigProvider), fullyQualifiedName: "aws.EksClusterEncryptionConfigProvider")]
    public interface IEksClusterEncryptionConfigProvider
    {
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterEncryptionConfigProvider), fullyQualifiedName: "aws.EksClusterEncryptionConfigProvider")]
        internal sealed class _Proxy : DeputyBase, aws.IEksClusterEncryptionConfigProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAthenaDatabaseEncryptionConfiguration), fullyQualifiedName: "aws.AthenaDatabaseEncryptionConfiguration")]
    public interface IAthenaDatabaseEncryptionConfiguration
    {
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}")]
        string EncryptionOption
        {
            get;
        }

        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaDatabaseEncryptionConfiguration), fullyQualifiedName: "aws.AthenaDatabaseEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAthenaDatabaseEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}")]
            public string EncryptionOption
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

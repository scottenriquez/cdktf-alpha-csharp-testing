using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMqBrokerEncryptionOptions), fullyQualifiedName: "aws.MqBrokerEncryptionOptions")]
    public interface IMqBrokerEncryptionOptions
    {
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "useAwsOwnedKey", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseAwsOwnedKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerEncryptionOptions), fullyQualifiedName: "aws.MqBrokerEncryptionOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IMqBrokerEncryptionOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useAwsOwnedKey", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseAwsOwnedKey
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}

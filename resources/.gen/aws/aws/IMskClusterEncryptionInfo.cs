using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterEncryptionInfo), fullyQualifiedName: "aws.MskClusterEncryptionInfo")]
    public interface IMskClusterEncryptionInfo
    {
        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionAtRestKmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_in_transit block.</summary>
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfoEncryptionInTransit\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IMskClusterEncryptionInfoEncryptionInTransit[]? EncryptionInTransit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterEncryptionInfo), fullyQualifiedName: "aws.MskClusterEncryptionInfo")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterEncryptionInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionAtRestKmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_in_transit block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfoEncryptionInTransit\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IMskClusterEncryptionInfoEncryptionInTransit[]? EncryptionInTransit
            {
                get => GetInstanceProperty<aws.IMskClusterEncryptionInfoEncryptionInTransit[]?>();
            }
        }
    }
}

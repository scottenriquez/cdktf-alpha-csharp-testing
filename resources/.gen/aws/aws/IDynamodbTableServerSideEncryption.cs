using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableServerSideEncryption), fullyQualifiedName: "aws.DynamodbTableServerSideEncryption")]
    public interface IDynamodbTableServerSideEncryption
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableServerSideEncryption), fullyQualifiedName: "aws.DynamodbTableServerSideEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.IDynamodbTableServerSideEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

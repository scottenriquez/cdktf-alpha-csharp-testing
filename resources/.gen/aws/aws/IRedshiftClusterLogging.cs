using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRedshiftClusterLogging), fullyQualifiedName: "aws.RedshiftClusterLogging")]
    public interface IRedshiftClusterLogging
    {
        [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enable
        {
            get;
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftClusterLogging), fullyQualifiedName: "aws.RedshiftClusterLogging")]
        internal sealed class _Proxy : DeputyBase, aws.IRedshiftClusterLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enable", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enable
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

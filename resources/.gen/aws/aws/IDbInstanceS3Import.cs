using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDbInstanceS3Import), fullyQualifiedName: "aws.DbInstanceS3Import")]
    public interface IDbInstanceS3Import
    {
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}")]
        string IngestionRole
        {
            get;
        }

        [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}")]
        string SourceEngine
        {
            get;
        }

        [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceEngineVersion
        {
            get;
        }

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbInstanceS3Import), fullyQualifiedName: "aws.DbInstanceS3Import")]
        internal sealed class _Proxy : DeputyBase, aws.IDbInstanceS3Import
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}")]
            public string IngestionRole
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceEngine
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceEngineVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

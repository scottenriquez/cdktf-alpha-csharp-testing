using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationS3S3Config), fullyQualifiedName: "aws.DatasyncLocationS3S3Config")]
    public interface IDatasyncLocationS3S3Config
    {
        [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketAccessRoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationS3S3Config), fullyQualifiedName: "aws.DatasyncLocationS3S3Config")]
        internal sealed class _Proxy : DeputyBase, aws.IDatasyncLocationS3S3Config
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketAccessRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

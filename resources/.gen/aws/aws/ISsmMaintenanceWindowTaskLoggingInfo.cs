using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskLoggingInfo), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskLoggingInfo")]
    public interface ISsmMaintenanceWindowTaskLoggingInfo
    {
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        string S3Region
        {
            get;
        }

        [JsiiProperty(name: "s3BucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskLoggingInfo), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskLoggingInfo")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskLoggingInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Region
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "s3BucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

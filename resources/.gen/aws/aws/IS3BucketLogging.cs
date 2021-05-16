using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketLogging), fullyQualifiedName: "aws.S3BucketLogging")]
    public interface IS3BucketLogging
    {
        [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
        string TargetBucket
        {
            get;
        }

        [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLogging), fullyQualifiedName: "aws.S3BucketLogging")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetBucket
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

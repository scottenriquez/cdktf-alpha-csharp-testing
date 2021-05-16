using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleRuleNoncurrentVersionTransition), fullyQualifiedName: "aws.S3BucketLifecycleRuleNoncurrentVersionTransition")]
    public interface IS3BucketLifecycleRuleNoncurrentVersionTransition
    {
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        string StorageClass
        {
            get;
        }

        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleRuleNoncurrentVersionTransition), fullyQualifiedName: "aws.S3BucketLifecycleRuleNoncurrentVersionTransition")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketLifecycleRuleNoncurrentVersionTransition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageClass
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

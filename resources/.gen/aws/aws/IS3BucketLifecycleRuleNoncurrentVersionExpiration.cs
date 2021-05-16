using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "aws.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
    public interface IS3BucketLifecycleRuleNoncurrentVersionExpiration
    {
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "aws.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketLifecycleRuleNoncurrentVersionExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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

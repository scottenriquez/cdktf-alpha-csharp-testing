using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventorySchedule), fullyQualifiedName: "aws.S3BucketInventorySchedule")]
    public interface IS3BucketInventorySchedule
    {
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        string Frequency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventorySchedule), fullyQualifiedName: "aws.S3BucketInventorySchedule")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketInventorySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
            public string Frequency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

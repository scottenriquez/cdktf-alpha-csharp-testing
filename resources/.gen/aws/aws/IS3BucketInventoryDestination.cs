using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestination), fullyQualifiedName: "aws.S3BucketInventoryDestination")]
    public interface IS3BucketInventoryDestination
    {
        /// <summary>bucket block.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucket\"},\"kind\":\"array\"}}")]
        aws.IS3BucketInventoryDestinationBucket[] Bucket
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestination), fullyQualifiedName: "aws.S3BucketInventoryDestination")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketInventoryDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bucket block.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucket\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketInventoryDestinationBucket[] Bucket
            {
                get => GetInstanceProperty<aws.IS3BucketInventoryDestinationBucket[]>()!;
            }
        }
    }
}

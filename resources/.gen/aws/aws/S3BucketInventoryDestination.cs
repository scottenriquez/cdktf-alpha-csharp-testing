using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketInventoryDestination")]
    public class S3BucketInventoryDestination : aws.IS3BucketInventoryDestination
    {
        /// <summary>bucket block.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestinationBucket\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketInventoryDestinationBucket[] Bucket
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketObjectLockConfiguration")]
    public class S3BucketObjectLockConfiguration : aws.IS3BucketObjectLockConfiguration
    {
        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ObjectLockEnabled
        {
            get;
            set;
        }

        /// <summary>rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfigurationRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketObjectLockConfigurationRule[]? Rule
        {
            get;
            set;
        }
    }
}

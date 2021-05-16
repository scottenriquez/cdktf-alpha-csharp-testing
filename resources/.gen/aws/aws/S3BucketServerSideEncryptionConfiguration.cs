using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketServerSideEncryptionConfiguration")]
    public class S3BucketServerSideEncryptionConfiguration : aws.IS3BucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfigurationRule\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketServerSideEncryptionConfigurationRule[] Rule
        {
            get;
            set;
        }
    }
}

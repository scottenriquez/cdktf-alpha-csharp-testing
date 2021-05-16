using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketServerSideEncryptionConfigurationRule")]
    public class S3BucketServerSideEncryptionConfigurationRule : aws.IS3BucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault[] ApplyServerSideEncryptionByDefault
        {
            get;
            set;
        }
    }
}

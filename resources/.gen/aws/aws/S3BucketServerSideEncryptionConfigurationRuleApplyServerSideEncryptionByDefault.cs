using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public class S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault : aws.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SseAlgorithm
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsMasterKeyId
        {
            get;
            set;
        }
    }
}

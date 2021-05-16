using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketObjectLockConfigurationRule")]
    public class S3BucketObjectLockConfigurationRule : aws.IS3BucketObjectLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfigurationRuleDefaultRetention\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketObjectLockConfigurationRuleDefaultRetention[] DefaultRetention
        {
            get;
            set;
        }
    }
}

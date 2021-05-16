using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
    public class S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation : aws.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
    {
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Owner
        {
            get;
            set;
        }
    }
}
